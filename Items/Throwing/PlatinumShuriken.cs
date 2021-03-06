using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OurStuff.Items.Throwing
{
    public class PlatinumShuriken : ModItem
	
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Platinum Shuriken");
			Tooltip.SetDefault("Super Shiny");
		}
        public override void SetDefaults()
        {   item.damage = 13;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 22;
            item.height = 22;
            item.useTime = 15;       //this is how fast you use the item
            item.useAnimation = 15;   //this is how fast the animation when the item is used
            item.useStyle = 1;      
            item.knockBack = 4;
            item.value = 10;
            item.rare = 2;
            item.reuseDelay = 6;    //this is the item delay
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("PlatinumShurikenProjectile"); 
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 999;       //this is the max stack of this item
            item.consumable = true;  //this make the item consumable when used
            item.noUseGraphic = false;
                       
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this , 10);
            recipe.AddRecipe();
        }
    }
}