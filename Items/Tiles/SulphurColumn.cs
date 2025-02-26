using Terraria.ModLoader;
using CalValEX.Tiles.MiscFurniture;

namespace CalValEX.Items.Tiles
{
    public class SulphurColumn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sulphurous Column");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.width = 16;
            Item.height = 28;
            Item.rare = 4;
            Item.createTile = ModContent.TileType<CalamityMod.Tiles.Abyss.SulphurousColumn>();
        }
    }
}