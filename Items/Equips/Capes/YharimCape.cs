using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Capes
{
    [AutoloadEquip(EquipType.Front)]
    public class YharimCape : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Cape");
            Tooltip.SetDefault("Not the true one, but still regal and elegant");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 32;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = 11;
            Item.accessory = true;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            //rarity 12 (Turquoise) = new Color(0, 255, 200)
            //rarity 13 (Pure Green) = new Color(0, 255, 0)
            //rarity 14 (Dark Blue) = new Color(43, 96, 222)
            //rarity 15 (Violet) = new Color(108, 45, 199)
            //rarity 16 (Hot Pink/Developer) = new Color(255, 0, 255)
            //rarity rainbow (no expert tag on item) = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB)
            //rarity rare variant = new Color(255, 140, 0)
            //rarity dedicated(patron items) = new Color(139, 0, 0)
            //look at https://calamitymod.gamepedia.com/Rarity to know where to use the colors
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.OverrideColor = new Color(255, 0, 255); //change the color accordingly to above
                }
            }
        }

       /*public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("AuricOre"), 200);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment"), 4);
                recipe.AddIngredient(ItemID.CrimsonCloak, 1);
                recipe.AddIngredient(ItemID.MysteriousCape, 1);
                recipe.AddIngredient(ItemID.RedCape, 1);
                recipe.AddIngredient(ItemID.WinterCape, 1);
                recipe.AddTile(ModLoader.GetMod("CalamityMod").TileType("DraedonsForge"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}