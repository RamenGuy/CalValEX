using Microsoft.Xna.Framework;
using Terraria;

namespace CalValEX.Projectiles.Pets
{
    public class SWeeb : ModFlyingPet
    {
        public override float TeleportThreshold => 1440f;

        public override Vector2 FlyingOffset => new Vector2(110f * -Main.player[Projectile.owner].direction, -50f);

        public override void SetStaticDefaults()
        {
            PetSetStaticDefaults(lightPet: false);
            DisplayName.SetDefault("Stasis Drone");
            Main.projFrames[Projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            PetSetDefaults();
            Projectile.width = 22;
            Projectile.height = 22;
            Projectile.ignoreWater = true;
        }

        public override void Animation(int state)
        {
            SimpleAnimation(speed: 12);
        }

        public override void PetFunctionality(Player player)
        {
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            if (player.dead)
                modPlayer.sWeeb = false;

            if (modPlayer.sWeeb)
                Projectile.timeLeft = 2;
        }
    }
}