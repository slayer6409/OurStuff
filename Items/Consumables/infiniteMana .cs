using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

    public class infiniteMana : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Mana potion");
			Tooltip.SetDefault("Infinite Mana, to a degree.");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 4;
            item.healMana = 100;
			item.autoReuse = true;
			item.buffType= BuffID.ManaSickness;
			item.buffTime = 150; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "infiniteLesserMana");
			recipe.AddIngredient(ItemID.ManaPotion, 255);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}