﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Items.Walls.Astral;
using CalValEX.Dusts;

namespace CalValEX.Walls.AstralSafe
{
    public class AstralDirtWallSafePlaced : ModWall
    {
        public override void SetStaticDefaults()
        {
            Main.wallHouse[Type] = true;
            ItemDrop = ModContent.ItemType<AstralDirtWall>();
            AddMapEntry(new Color(37, 10, 38));
            DustType = ModContent.DustType<AstralDust>();
        }
    }
}