using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

    public class BloodDiamond : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Diamond");
			Tooltip.SetDefault("Revert to Pre-HardMode");
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
            item.rare = 4;
			item.autoReuse = false;
			item.maxStack = 999;
			item.buffType= BuffID.Regeneration;
			item.buffTime = 1; 
        }

        public override bool ConsumeItem(Player player)
        {
            if (Main.hardMode)
            {
                Main.NewText("THE WORLD HAS REVERTED BACK INTO PRE HARD MODE");
                Main.hardMode = false;
            }
            else
            {
                Main.NewText("The World is already in pre hard mode");
            }
           
            return base.ConsumeItem(player);
        }
    }
}