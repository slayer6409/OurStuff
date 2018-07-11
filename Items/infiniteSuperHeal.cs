using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items{

    public class infiniteSuperHeal : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Super Healing Potion");
			Tooltip.SetDefault("Infinite Health, to a degree. Don't Use Your Auto Healing Button");
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
			item.potion = true;
            item.value = 100;                
            item.rare = 4;
            item.healLife = 200;
			item.autoReuse = true;
			item.buffType= 21;
			item.buffTime = 2500; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperHealingPotion	, 255);
			recipe.AddIngredient(mod, "infiniteGreaterHeal");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}