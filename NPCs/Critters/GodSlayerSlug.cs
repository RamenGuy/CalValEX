using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Critters;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace CalValEX.NPCs.Critters
{
    public class GodSlayerSlug : ModNPC
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("God Slayer Slug");
            Main.npcFrameCount[NPC.type] = 4;
            Main.npcCatchable[NPC.type] = true;
            NPCID.Sets.CountsAsCritter[NPC.type] = true;
        }

        public override void SetDefaults()
        {
            NPC.width = 22;
            NPC.height = 18;
            //NPC.aiStyle = 67;
            //NPC.damage = 0;
            //NPC.defense = 0;
            //NPC.lifeMax = 2000;
            //NPC.HitSound = SoundID.NPCHit38;
            //NPC.DeathSound = SoundID.NPCDeath1;
            //NPC.npcSlots = 0.5f;
            //NPC.noGravity = true;
            //NPC.catchItem = 2007;

            NPC.CloneDefaults(NPCID.GlowingSnail);
            NPC.catchItem = (short)ItemType<GodSlayerSlugItem>();
            NPC.lavaImmune = false;
            NPC.chaseable = false;
            for (int i = 0; i < NPC.buffImmune.Length; i++)
            {
                NPC.buffImmune[(ModContent.BuffType<CalamityMod.Buffs.DamageOverTime.GodSlayerInferno>())] = false;
            }
            AIType = NPCID.GlowingSnail;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.lifeMax = 5000;
            Banner = NPC.type;
            BannerItem = ItemType<Items.Tiles.Banners.GodSlayerSlugBanner>();
        }
        public override void SetBestiary(Terraria.GameContent.Bestiary.BestiaryDatabase database, Terraria.GameContent.Bestiary.BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.UIInfoProvider = new Terraria.GameContent.Bestiary.CommonEnemyUICollectionInfoProvider(ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[Type], quickUnlock: true);
            bestiaryEntry.Info.AddRange(new Terraria.GameContent.Bestiary.IBestiaryInfoElement[] {
                Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Sky,
                new Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement("Mimicking the purple worm-like appearance of the cosmic worms, this little bug peacefully wanders the upper atmosphere."),
            });
        }
        public override bool? CanBeHitByItem(Player player, Item item) => null;

        public override bool? CanBeHitByProjectile(Projectile projectile) => null;

        public override void AI()
        {
            if (NPC.position.Y > Main.worldSurface * 7.0)
            {
                NPC.life = 0;
                NPC.HitEffect();
                NPC.active = false;
                NPC.netUpdate = true;
                Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.position.X, NPC.position.Y, 0f, 7f, ProjectileID.FallingStar, 0, 0f, Main.myPlayer);
            }
            else
            {
                return;
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            //Mod calamityMod = ModLoader.GetMod("CalamityMod"); //this is to get calamity mod, you have to add 'weakReferences = CalamityMod@1.4.4.4' (without the '') in your build.txt for this to work
            if (CalamityMod.DownedBossSystem.downedDoG && !CalValEXConfig.Instance.CritterSpawns && spawnInfo.Player.ZoneSkyHeight)
            {
                if (Main.raining)
                {
                    return 0.4f;
                }
                else
                {
                    return 0.05f;
                }
            }
            else
            {
                return 0f;
            }
        }
        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter += 0.1f;
            NPC.frameCounter %= Main.npcFrameCount[NPC.type];
            int frame = (int)NPC.frameCounter;
            NPC.frame.Y = frame * frameHeight;
        }

    }
}