using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Pets
{
    public class DiscardedCollar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Radioactive Catnip");
            Tooltip
                .SetDefault("Doused in uranium, may morph organic life into terrifying abominations");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.UseSound = SoundID.NPCHit55;
            item.shoot = mod.ProjectileType("Catfish");
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("CatfishBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}