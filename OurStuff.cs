using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff
{
	class OurStuff : Mod
	{
		public OurStuff()
		{
			
			


			
			
			
		}
		
		
		
		public override void AddRecipeGroups()
		{
			RecipeGroup EvilBar = new RecipeGroup(() => Lang.misc[37] + " Evil Bar", new int[]
			{
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});
		RecipeGroup.RegisterGroup("OurStuff:EvilBar", EvilBar);
		
			RecipeGroup EvilMaterial = new RecipeGroup(()=> Lang.misc[37] + " Evil Material", new int[]
			{
				
				ItemID.ShadowScale,
				ItemID.TissueSample			
			});
		RecipeGroup.RegisterGroup("OurStuff:EvilMaterial", EvilMaterial);
			
		}
	}

}