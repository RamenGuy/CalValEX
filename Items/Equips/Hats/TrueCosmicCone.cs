﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Hats
{
    [AutoloadEquip(EquipType.Head)]
    public class TrueCosmicCone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Cosmic Cone");
            Tooltip.SetDefault("'A cosmically large hat so pointy it could pierce through dimensions.'");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = 11;
            Item.vanity = true;
            Terraria.ID.ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
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
                    tooltipLine.OverrideColor = new Color(43, 96, 222); //change the color accordingly to above
                }
            }
        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<CalValEXPlayer>().conejo = true;
        }

        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<CalValEXPlayer>().conejo = true;
        }
        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
           
            if (calamityMod != null)
            {
                recipe.AddIngredient(ModContent.ItemType<SpectralstormHat>());
                recipe.AddIngredient(calamityMod.ItemType("CosmiliteBar"), 10);
                recipe.AddIngredient(calamityMod.ItemType("GalacticaSingularity"), 5);
                recipe.AddIngredient(mod.ItemType("CosmicCone"), 1);
                recipe.AddTile(calamityMod.TileType("CosmicAnvil"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}