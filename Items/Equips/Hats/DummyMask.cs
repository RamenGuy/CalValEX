using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Hats
{
    [AutoloadEquip(EquipType.Head)]
    public class DummyMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dummy Mask");
            Tooltip.SetDefault("The only dummy here is you.");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 0, 0, 0);
            Item.rare = 3;
            Item.accessory = true;
            Item.vanity = true;
        }
    }
}