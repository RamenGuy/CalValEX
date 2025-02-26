using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Balloons
{
    [AutoloadEquip(EquipType.Balloon)]
    public class BoB2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bundle of Water Balloons");
            Tooltip.SetDefault("The Party Girl can tie this for you\n'How did none of them pop down there?'");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.accessory = true;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.OverrideColor = new Color(0, 255, 0);
                }
            }
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BoxBalloon>());
            recipe.AddIngredient(ModContent.ItemType<ChaosBalloon>());
            recipe.AddIngredient(ModContent.ItemType<Mirballoon>());
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}