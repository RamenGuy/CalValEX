using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Hats
{
    [AutoloadEquip(EquipType.Head)]
    public class DevilfishMask1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Curly Devil Fish Mask");
            Tooltip
                .SetDefault("Edgy");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.rare = 6;
            Item.vanity = true;
            Item.value = Item.sellPrice(0, 2, 0, 0);
        }
    }
}