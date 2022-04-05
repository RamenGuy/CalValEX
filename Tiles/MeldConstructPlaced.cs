using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalValEX.Tiles
{
    public class MeldConstructPlaced : ModTile
    {
        public override void SetStaticDefaults()
        {
            //Mod calamityMod = ModLoader.GetMod("CalamityMod");
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = false;
            Main.tileSolidTop[Type] = true;
            Main.tileLavaDeath[Type] = true;
            //drop = calamityMod.ItemType("MeldiateBar");
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            AddMapEntry(new Color(70, 45, 45));
        }
    }
}