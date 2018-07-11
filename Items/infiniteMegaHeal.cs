using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items{

    public class infiniteMegaHeal : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Mega Healing Potion");
			Tooltip.SetDefault("Seems Useless");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 3;
            item.useTime = 3;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 36;
            item.height = 60;
            item.value = 100;                
            item.rare = 4;
            item.healLife = 10;
			item.autoReuse = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"infiniteSuperHeal",5);
			recipe.AddIngredient(mod,"infiniteGreaterHeal",5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}