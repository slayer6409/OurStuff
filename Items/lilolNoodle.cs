using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items
{
	public class lilolNoodle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("lil ol' Noodle");
			Tooltip.SetDefault("less Floppery");
		}
		public override void SetDefaults()
		{
			item.damage = 10000000;
			item.thrown	= true;
			item.width = 200;
			item.height = 200;
			item.useTime = 5;
			item.useAnimation = 6;
			item.useStyle = 3;
			item.knockBack = 1000;
			item.value = 10000000;
			item.expert= true;		
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

	}
}
