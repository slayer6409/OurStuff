using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuff.NPCs.Enemies
{
   	public class Phantom : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
            npc.damage = 20;
            npc.lifeMax = 60;
            npc.life = 60;
			npc.defense = 4;
			npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}


        public override void NPCLoot()
        {
            int loots = Main.rand.Next(13);
            switch (loots)
            {
                case 1: Item.NewItem(npc.getRect(), ItemID.Topaz, Main.rand.Next(2)); break;
                case 2: Item.NewItem(npc.getRect(), ItemID.Diamond, Main.rand.Next(2)); break;
                case 3: Item.NewItem(npc.getRect(), ItemID.Emerald, Main.rand.Next(2)); break;
                case 4: Item.NewItem(npc.getRect(), ItemID.Amethyst, Main.rand.Next(2)); break;
                case 5: Item.NewItem(npc.getRect(), ItemID.Amber, Main.rand.Next(2)); break;
                case 6: Item.NewItem(npc.getRect(), ItemID.Ruby, Main.rand.Next(2)); break;
                case 7: Item.NewItem(npc.getRect(), ItemID.Hook, Main.rand.Next(2)); break;
                case 8: Item.NewItem(npc.getRect(), ItemID.Sapphire, Main.rand.Next(2)); break;
                case 9:
                    if (Main.rand.Next(200) == 169)
                    {
                        if (Main.hardMode == false)
                        {
                            Main.hardMode = true;
                            Main.NewText("THE WORLD IS NOW IN HARD MODE");
                        }
                        else if (Main.hardMode == true)
                        {
                            Main.hardMode = false;
                            Main.NewText("THE WORLD HAS REVERTED BACK INTO PRE HARD MODE");
                        }
                        else if (Main.rand.Next(1000) == 904)
                        {
                            Item.NewItem(npc.getRect(), ItemID.PlatinumCoin, 100);

                        }
                    }
                    else
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("BloodDiamond"));
                    }
                    break;
                
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.3f;
		}

	}
}