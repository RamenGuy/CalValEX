using Terraria.ID; using CalValEX.Tiles.Paintings;
using Terraria.ModLoader;

namespace CalValEX.Items.Tiles.Paintings
{
    public class SundayAfternoon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A Sunday Afternoon in the World of Calamity");
            Tooltip.SetDefault("'Mathew Maple'");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<SundayAfternoonCalPlaced>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = 11;
            Item.expert = true;
        }
    }
}