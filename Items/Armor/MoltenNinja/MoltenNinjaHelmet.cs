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

namespace OurStuff.Items.Armor.MoltenNinja
{
	[AutoloadEquip(EquipType.Head)]
	public class MoltenNinjaHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Molten Ninja Mask");
			Tooltip.SetDefault("Sneaky Fire"
			+ "\n+8 Defense"
			+ "\n+33% Chance to not "	
			+ "\n+consume thrown Item"
			+ "\nSet Bonus: " 
			+ "\nImmune to OnFire");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.thrownCost33 = true;
			//player.AddBuff(BuffID.Shine, 2);
		}
		
		public override bool IsArmorSet(Item head, Item body, Item legs){
			
			return body.type == mod.ItemType("MoltenNinjaBody") && legs.type == mod.ItemType("MoltenNinjaLegs");
			
		}
		
		public override void UpdateArmorSet(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.NinjaHood, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}