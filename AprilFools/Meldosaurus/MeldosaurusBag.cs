﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CalamityMod;

namespace CalValEX.AprilFools.Meldosaurus
{
	public class MeldosaurusBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<Meldosaurus>();
		public override void SetStaticDefaults()
		{
			SacrificeTotal = 3;
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}
		public override void SetDefaults()
		{
			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 24;
			Item.height = 24;
			Item.rare = 9;
			Item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor(player.GetSource_OpenItem(Item.type));
			DropHelper.DropItemChance(player.GetSource_OpenItem(Item.type), player, ModContent.ItemType<MeldosaurusMask>(), 7);
			DropHelper.DropItem(player.GetSource_OpenItem(Item.type), player, ModContent.ItemType<CalamityMod.Items.Materials.MeldBlob>(), 1, 2);
			float dropChance = DropHelper.NormalWeaponDropRateFloat;
			DropHelper.DropItemChance(player.GetSource_OpenItem(Item.type), player, ModContent.ItemType<ShadesBane>(), dropChance);
			DropHelper.DropItemChance(player.GetSource_OpenItem(Item.type), player, ModContent.ItemType<Nyanthrop>(), dropChance);
			//player.QuickSpawnItem(ModContent.ItemType("MeldExpert"));
		}
	}
}