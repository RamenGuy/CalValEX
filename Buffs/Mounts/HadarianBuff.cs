using Terraria;
using Terraria.ModLoader;
using CalValEX.Items.Mounts.LimitedFlight;

namespace CalValEX.Buffs.Mounts
{
    public class HadarianBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Hadarian Fledgling");
            //Description.SetDefault("SCREEEE");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<HadarianMount>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}