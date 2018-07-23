using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Armor.Chef
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChefArmorLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Chef's Legs");
			Tooltip.SetDefault("Professional"
			+ "\n+7 Defense"
			+ "\n+10 %Movement Speed"
			+ "\n+20 Mana");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.10f;
			player.statManaMax2 += 20;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddRecipeGroup("OurStuff:EvilBar",10);
			recipe.AddRecipeGroup("OurStuff:EvilMaterial",10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}