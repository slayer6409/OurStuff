using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

   
    public class TimeSwapPotion : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Time Swap Potion");
			Tooltip.SetDefault("Swaps from night to day");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 5;
			item.autoReuse = false;
            item.buffType = BuffID.WellFed;
            item.buffTime = 1;
        }



        public override bool ConsumeItem(Player player)
        {
            bool debug = false;
            if (Main.dayTime)
            {
                Main.dayTime = false;
                if (debug)
                {
                    Main.NewText("The new time is: " + Main.time);
                }
            }
            else
            {
                Main.dayTime = true;
                if (debug)
                {
                    Main.NewText("The new time is: " + Main.time);
                }
                
            }
            
            if (Main.netMode == 2)
                NetMessage.SendData(7, -1, -1, null, 0, 0f, 0f, 0f, 0, 0, 0);
            return base.ConsumeItem(player);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ItemID.Daybloom, 2);
			recipe.AddIngredient(ItemID.Moonglow, 2);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}