using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Terraria.GameInput;

namespace OurStuff.Items.Armor.Chef
{
	[AutoloadEquip(EquipType.Head)]
	public class ChefArmorHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Chef's Hat");
			Tooltip.SetDefault("Professional"
			+ "\n+8 Defense"
			+ "\n+2 Minions"			
			+ "\nSet Bonus: " 
			+ "\nIncreased Life Regen");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}
		
		public override bool IsArmorSet(Item head, Item body, Item legs){
			
			return body.type == mod.ItemType("ChefArmorBody") && legs.type == mod.ItemType("ChefArmorLegs");
			
		}
		
		public override void UpdateArmorSet(Player player)
		{
			player.lifeRegen += 1;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddRecipeGroup("OurStuff:EvilBar",10);
			recipe.AddRecipeGroup("OurStuff:EvilMaterial",10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}