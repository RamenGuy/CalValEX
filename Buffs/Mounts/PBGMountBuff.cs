using Terraria;
using Terraria.ModLoader;
using CalValEX.Items.Mounts.LimitedFlight;

namespace CalValEX.Buffs.Mounts
{
    public class PBGMountBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Plague Rider");
            //Description.SetDefault("Ya gotta beelieve in yourself");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<PBGMount>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}