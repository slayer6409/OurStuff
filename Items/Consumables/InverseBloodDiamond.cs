using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Consumables{

    public class InverseBloodDiamond : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Inverse Blood Diamond");
			Tooltip.SetDefault("Make It Hard Mode Again");
		}
        public override void SetDefaults()
        {
            
			item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;                
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 4;
			item.autoReuse = false;
			item.maxStack = 1;

        }

        public override bool UseItem(Player player)
        {
            if (!Main.hardMode)
            {
                Main.NewText("THE WORLD HAS REVERTED BACK INTO HARD MODE");
                Main.hardMode = true;
            }
           
            return base.UseItem(player);
        }
    }
}