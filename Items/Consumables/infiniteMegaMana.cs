using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

    public class infiniteMegaMana : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Mega Mana potion");
			Tooltip.SetDefault("Infinite Mana, to a degree.");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 5;
            item.useTime = 5;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 15;
            item.height = 21;
            item.value = 100;                
            item.rare = 9;
            item.healMana = 99999;
			item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "infiniteGreaterMana",5);
			recipe.AddIngredient(mod, "infiniteSuperMana", 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}