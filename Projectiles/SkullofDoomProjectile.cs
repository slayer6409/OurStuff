using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
 
namespace OurStuff.Projectiles
{
    public class SkullofDoomProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            //projectile.name = "SkullofDoomProjectile";
            projectile.width = 22;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.penetrate = 6;                       //this is the projectile penetration
            Main.projFrames[projectile.type] = 6;           //this is projectile frames
            projectile.hostile = false;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }
		
		

 
        public override void AI()
        {
                                                                //this is projectile dust
            //int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 9, projectile.height + 9, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
            //Main.dust[DustID2].noGravity = true;
            int num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 3f + 1f, projectile.position.Y + 1f - projectile.velocity.Y * 4f), 8, 8, 107, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
			Main.dust[num309].velocity *= -0.25f;
			num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 8, 8, 107, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
			Main.dust[num309].velocity *= -0.25f;
			Main.dust[num309].position -= projectile.velocity * 0.5f;

			//this make that the projectile faces the right way
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
           
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
                if (projectile.frame > 5) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }
    }
}