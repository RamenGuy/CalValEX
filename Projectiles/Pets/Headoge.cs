using Microsoft.Xna.Framework;
using Terraria;

namespace CalValEX.Projectiles.Pets
{
    public class Headoge : ModFlyingPet
    {
        public override Vector2 FlyingOffset => new Vector2(68f * - Main.player[Projectile.owner].direction, -50f);

        public override void SetStaticDefaults()
        {
            PetSetStaticDefaults(lightPet: false);
            DisplayName.SetDefault("Headoge");
            Main.projFrames[Projectile.type] = 6;
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
            SimpleAnimation(speed: 7);
        }

        public override void PetFunctionality(Player player)
        {
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            if (player.dead)
                modPlayer.hDoge = false;

            if (modPlayer.hDoge)
                Projectile.timeLeft = 2;
        }
    }
}