using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

    public class spaghet : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spaghet");
			Tooltip.SetDefault("Someone touch my spaghet");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item2;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 4;
            item.healLife = 50;
			item.autoReuse = false;
			item.buffType= BuffID.WellFed;
			item.buffTime = 12345; 
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LesserHealingPotion, 50);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}