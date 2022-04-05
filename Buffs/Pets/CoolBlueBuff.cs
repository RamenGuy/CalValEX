﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Buffs.Pets
{
    public class CoolBlueBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cool Blue Dudes");
            Description.SetDefault("Some very coul bleu doods");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().bSignut = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.CoolBlueSignut>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.GetProjectileSource_Buff(buffIndex), player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.CoolBlueSignut>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().bSlime = true;
            bool petProjectileNotSpawnedf = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.CoolBlueSlime>()] <= 0;
            if (petProjectileNotSpawnedf && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.GetProjectileSource_Buff(buffIndex), player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.CoolBlueSlime>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}