using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items
{
	public class fullerColor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fuller Color");
			Tooltip.SetDefault("Are you on drugs?");
		}
		public override void SetDefaults()
		{
			item.damage = 75;
			item.melee = true;
			item.width = 128;
			item.height = 128;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 2;
			item.shoot = mod.ProjectileType ("FullerColorProjectile");
			item.shootSpeed = 5f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 4);
			recipe.AddIngredient(ItemID.Diamond, 4);
			recipe.AddIngredient(ItemID.Emerald, 4);
			recipe.AddIngredient(ItemID.Topaz, 4);
			recipe.AddIngredient(ItemID.Amethyst, 4);
			recipe.AddIngredient(ItemID.Sapphire, 4);
			recipe.AddIngredient(ItemID.Amber, 4);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.CrystalShard, 10);
			recipe.AddIngredient(mod, "fullColor");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
