using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Armor.MoltenNinja
{
	[AutoloadEquip(EquipType.Body)]
	public class MoltenNinjaBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Molten Ninja Shirt");
			Tooltip.SetDefault("Sneaky Fire"
			+ "\n+9 Defense"
			+ "\n+10% Increased Thrown Damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = 2;
			item.defense = 9;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.10f;
			//player.statManaMax2 += 20;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.NinjaShirt, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}