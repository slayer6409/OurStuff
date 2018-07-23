using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Armor.MoltenNinja
{
	[AutoloadEquip(EquipType.Legs)]
	public class MoltenNinjaLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Molten Ninja Pants");
			Tooltip.SetDefault("Sneaky Fire"
			+ "\n+8 Defense"
			+ "\n+10 %Movement Speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.10f;
			//player.statManaMax2 += 20;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.NinjaPants, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}