using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Projectiles.Pets
{
    public class TUB : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TUB");
            Main.projFrames[Projectile.type] = 11;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(334);
            base.AIType = 334;
            base.DrawOriginOffsetY = -14;
            base.DrawOffsetX = -10;
        }

        public override bool PreAI()
        {
            _ = Main.player[Projectile.owner];
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();
            if (player.dead)
            {
                modPlayer.tub = false;
            }
            if (modPlayer.tub)
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}