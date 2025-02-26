using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class PlaguePack : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beelzebooster");
            Tooltip.SetDefault("And they wonder how bees can get themselves off the ground\n" + "Horizontal speed: 7.8\n" + "Acceleration multiplier: 1.9\n" + "Flight time: 170");
            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            Terraria.ID.ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new Terraria.DataStructures.WingStats(170, 7.8f, 1.9f);
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 34;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.rare = 8;
            Item.accessory = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 0.4f;
            maxAscentMultiplier = 1.4f;
            constantAscend = 0.08f;
        }
    }
}