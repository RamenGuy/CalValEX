using Terraria.ModLoader;
using CalValEX.Tiles.Plants;

namespace CalValEX.Items.Tiles.Plants
{
    public class AstralOldYellow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potted Yellow Xenomonolith");
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
            Item.createTile = ModContent.TileType<AstralOldYellowPlaced>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = 5;
        }
    }
}