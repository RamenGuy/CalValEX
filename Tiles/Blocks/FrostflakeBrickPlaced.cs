using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CalValEX.Items.Tiles.Blocks;

namespace CalValEX.Tiles.Blocks
{
    public class FrostflakeBrickPlaced : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[this.Type] = true;
            ItemDrop = ModContent.ItemType<FrostflakeBrick>();
            AddMapEntry(new Color(66, 242, 245));
            DustType = 92;
            MinPick = 65;
            HitSound = SoundID.Tink;
        }
    }
}