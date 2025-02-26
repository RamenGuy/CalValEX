﻿using Terraria;
using Terraria.ModLoader;
using CalValEX.Items.Mounts.Ground;

namespace CalValEX.Buffs.Mounts
{
    public class BloodstoneCarriageBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Bloodstone Carriage");
            //Description.SetDefault("You could even call it a mi-");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<CalValEXPlayer>().carriage = true;
            player.mount.SetMount(ModContent.MountType<BloodstoneCarriage>(), player);
            player.buffTime[buffIndex] = 10;
            CalValEX.MountNerf(player, 0.8f, 0.75f);
        }
    }
}