using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class TerminalWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wings of Termina");
            Tooltip.SetDefault("Through death and destruction new heights are attained, \non wings of a pandemonic butterfly \n" + "Horizontal speed: 1\n" + "Acceleration multiplier: 1\n" + "Flight time: 60");
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(10, 6));
            /// ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            ItemID.Sets.ItemIconPulse[Item.type] = false;
            ItemID.Sets.ItemNoGravity[Item.type] = false;
            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            Terraria.ID.ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new Terraria.DataStructures.WingStats(60, 1f, 1f);
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.sellPrice(0, 0, 0, 1);
           
            Item.rare = 11;
            Item.expert = true;
            Item.accessory = true;
            //Item.vanity = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 1;
            ascentWhenRising = 1f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1f;
            constantAscend = 1f;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
           
            if (calamityMod != null)
            {
                recipe.AddIngredient(ModContent.ItemType<Termipebbles>(), 5);
                recipe.AddIngredient(calamityMod.ItemType("Rock"));
                recipe.AddTile(calamityMod.TileType("DraedonsForge"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}