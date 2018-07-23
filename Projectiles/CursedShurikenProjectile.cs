using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OurStuff.Projectiles
{
    public class CursedShurikenProjectile : ModProjectile
    {
 
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 5;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Shuriken;
			Main.projFrames[projectile.type] = 1; 
			projectile.tileCollide = true; 
        }
 
        public override void AI()
        {            
                projectile.ai[0] += 1f;
				Lighting.AddLight(projectile.position, 1f, 1f, 0f);
            if (projectile.ai[0] >= 75f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 0.99f;    // projectile velocity
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                           // sound that the projectile make when hiting the terrain
            {
                projectile.Kill();
				if (Main.rand.Next(10) == 0){
					Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, (mod.ItemType("CursedShuriken")));
				}
 
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(1) == 0)
            {
                target.AddBuff(BuffID.CursedInferno, 90, true);
            }
        }

		public virtual bool CanHitPvp(Player target)
		{
			return true;
		}
		
		/*public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 5) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 3) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }*/
    }
}