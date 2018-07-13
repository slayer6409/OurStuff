using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Magic
{
	public class SkullofDoom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skull of Doom");
			Tooltip.SetDefault("Oof");
		}
		public override void SetDefaults()
		{
			item.damage = 95;
			item.magic = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 2000;
			item.rare = 8;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("SkullofDoomProjectile");
			item.shootSpeed = 7f;
			item.mana = 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ancientSkull");
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.CursedFlame, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
