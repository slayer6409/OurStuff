using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Magic
{
	public class ancientSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Skull");
			Tooltip.SetDefault("It's really Old");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.magic = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 1000;
			item.rare = 6;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("ancientSkullProjectile");
			item.shootSpeed = 7f;
			item.mana = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddIngredient(ItemID.WaterCandle, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
