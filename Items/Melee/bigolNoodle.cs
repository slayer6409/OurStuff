using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.Items.Melee
{
	public class bigolNoodle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big ol' Noodle");
			Tooltip.SetDefault("Floppery");
		}
		public override void SetDefaults()
		{
			item.damage = 10000000;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 100;
			item.value = 10000000;
			item.expert = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

	}
}
