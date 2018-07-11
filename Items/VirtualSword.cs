using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace OurStuff.Items
{
	public class VirtualSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Virtual Sword");
			Tooltip.SetDefault("Be The Hacker");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Confused, 180);
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.Wire, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
