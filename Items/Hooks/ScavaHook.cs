using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CalValEX.Items.Hooks
{
    public class ScavaHook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Scavenger Claw");
            Tooltip.SetDefault("Here to gouge out your eyes, runic style!\nReach: 50\nLaunch Velocity: 19\nPull Velocity: 25");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.BatHook);
            Item.shootSpeed = 19f;
            Item.shoot = ProjectileType<ScavaClaw>();
            Item.rare = 9;
        }
    }
}