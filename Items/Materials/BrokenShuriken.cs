using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OurStuff.Items.Materials
{
    public class BrokenShuriken : ModItem
	
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Shuriken");
			Tooltip.SetDefault("It's broke");
		}
        public override void SetDefaults()
        {   item.width = 22;
            item.height = 22;
            item.value = 10;
            item.rare = 2;
            item.maxStack = 999;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = false;
                       
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}