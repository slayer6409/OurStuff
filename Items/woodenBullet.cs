using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items{
 public class woodenBullet : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden ammo");
			Tooltip.SetDefault("It does not seem very effective");
		}
		public override void SetDefaults()
		{
			item.damage = 3;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("woodenBulletShot");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
		
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood , 10);
			recipe.AddIngredient(ItemID.IronBar , 2);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
		
		
		
	}
	
	
	
}