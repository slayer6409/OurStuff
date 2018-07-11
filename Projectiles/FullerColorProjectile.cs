using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OurStuff.Projectiles
{
    public class FullerColorProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            //projectile.name = "FullerColorProjectile";
            projectile.width = 68;
            projectile.height = 68;
            projectile.friendly = true;
            projectile.penetrate = 1;                       //this is the projectile penetration
            Main.projFrames[projectile.type] = 8;           //this is projectile frames
            projectile.hostile = false;
            projectile.melee = true;                        //this make the projectile do melee damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }
		

 
        public override void AI()
        {
                                                                //this is projectile dust
            //int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 9, projectile.height + 9, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
            //Main.dust[DustID2].noGravity = true;
			//this make that the projectile faces the right way
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X)+ 0.77f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
			Lighting.AddLight(projectile.position, 1f, 1f, 1f);
           
            if (projectile.localAI[0] > 330f) //projectile time left before disappears
            {
                projectile.Kill();
            }
           
        }
        public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 5) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 7) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }
    }
}