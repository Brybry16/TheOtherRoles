using System.Collections.Generic;
using UnityEngine;
using static BetterOtherRoles.BetterOtherRoles;
using Types = BetterOtherRoles.CustomOption.CustomOptionType;

namespace BetterOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        public static string[] presets = new string[]{"Preset 1", "Preset 2", "Random Preset Skeld", "Random Preset Mira HQ", "Random Preset Polus", "Random Preset Airship", "Random Preset Submerged" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption crewmateRolesFill;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption anyPlayerCanStopStart;
        public static CustomOption enableEventMode;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;
        public static CustomOption mayorChooseSingleVote;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;
        public static CustomOption portalmakerCanPortalFromAnywhere;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterFlashlightWidth;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchMode;
        public static CustomOption snitchTargets;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;
        public static CustomOption mediumChanceAdditionalInfo;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;
        public static CustomOption thiefCanStealWithGuess;


        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombDestructionTime;
        public static CustomOption bomberBombDestructionRange;
        public static CustomOption bomberBombHearRange;
        public static CustomOption bomberDefuseDuration;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberBombActiveAfter;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;
        public static CustomOption finishTasksBeforeHauntingOrZoomingOut;
        public static CustomOption camsNightVision;
        public static CustomOption camsNoNightVisionIfImpVision;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableFungle;
        public static CustomOption dynamicMapEnableSubmerged;
        public static CustomOption dynamicMapSeparateSettings;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserForceThiefGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;
        public static CustomOption guesserGamemodeSidekickIsAlwaysGuesser;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        // Prop Hunt Settings
        public static CustomOption propHuntMap;
        public static CustomOption propHuntTimer;
        public static CustomOption propHuntNumberOfHunters;
        public static CustomOption hunterInitialBlackoutTime;
        public static CustomOption hunterMissCooldown;
        public static CustomOption hunterHitCooldown;
        public static CustomOption hunterMaxMissesBeforeDeath;
        public static CustomOption propBecomesHunterWhenFound;
        public static CustomOption propHunterVision;
        public static CustomOption propVision;
        public static CustomOption propHuntRevealCooldown;
        public static CustomOption propHuntRevealDuration;
        public static CustomOption propHuntRevealPunish;
        public static CustomOption propHuntUnstuckCooldown;
        public static CustomOption propHuntUnstuckDuration;
        public static CustomOption propHuntInvisCooldown;
        public static CustomOption propHuntInvisDuration;
        public static CustomOption propHuntSpeedboostCooldown;
        public static CustomOption propHuntSpeedboostDuration;
        public static CustomOption propHuntSpeedboostSpeed;
        public static CustomOption propHuntSpeedboostEnabled;
        public static CustomOption propHuntInvisEnabled;
        public static CustomOption propHuntAdminCooldown;
        public static CustomOption propHuntFindCooldown;
        public static CustomOption propHuntFindDuration;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static bool isMapSelectionOption(CustomOption option) {
            return option == CustomOptionHolder.propHuntMap && option == CustomOptionHolder.hideNSeekMap;
        }

        public static void Load() {

            CustomOption.vanillaSettings = TheOtherRolesPlugin.Instance.Config.Bind("Preset0", "VanillaOptions", "");

            // Role Options
            presetSelection = CustomOption.Create(0, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Preset"), presets, null, true);
            activateRoles = CustomOption.Create(1, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Enable Mod Roles And Block Vanilla Roles"), true, null, true);
            anyPlayerCanStopStart = CustomOption.Create(2, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Any Player Can Stop The Start"), false, null, false);

            if (Utilities.EventUtility.canBeEnabled) enableEventMode = CustomOption.Create(10423, CustomOption.CustomOptionType.General, cs(Color.green, "Enable Special Mode"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Minimum Crewmate Roles"), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Maximum Crewmate Roles"), 15f, 0f, 15f, 1f);
            crewmateRolesFill = CustomOption.Create(308, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Fill Crewmate Roles\n(Ignores Min/Max)"), false);
            neutralRolesCountMin = CustomOption.Create(302, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Minimum Neutral Roles"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Maximum Neutral Roles"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Minimum Impostor Roles"), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Maximum Impostor Roles"), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Minimum Modifiers"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, CustomOption.CustomOptionType.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Maximum Modifiers"), 15f, 0f, 15f, 1f);
            
            mafiaSpawnRate = CustomOption.Create(18, CustomOption.CustomOptionType.Impostor, cs(BetterOtherRoles.Janitor.color, "Mafia"), rates, null, true);
            janitorCooldown = CustomOption.Create(19, CustomOption.CustomOptionType.Impostor, "Janitor Cooldown", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, CustomOption.CustomOptionType.Impostor, cs(Morphling.color, "Morphling"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, CustomOption.CustomOptionType.Impostor, "Morphling Cooldown", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, CustomOption.CustomOptionType.Impostor, "Morph Duration", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, CustomOption.CustomOptionType.Impostor, cs(Camouflager.color, "Camouflager"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, CustomOption.CustomOptionType.Impostor, "Camouflager Cooldown", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, CustomOption.CustomOptionType.Impostor, "Camo Duration", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, CustomOption.CustomOptionType.Impostor, cs(Vampire.color, "Vampire"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, CustomOption.CustomOptionType.Impostor, "Vampire Kill Delay", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, CustomOption.CustomOptionType.Impostor, "Vampire Cooldown", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, CustomOption.CustomOptionType.Impostor, "Vampire Can Kill Near Garlics", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230, CustomOption.CustomOptionType.Impostor, cs(Eraser.color, "Eraser"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, CustomOption.CustomOptionType.Impostor, "Eraser Cooldown", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, CustomOption.CustomOptionType.Impostor, "Eraser Can Erase Anyone", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, CustomOption.CustomOptionType.Impostor, cs(Trickster.color, "Trickster"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, CustomOption.CustomOptionType.Impostor, "Trickster Box Cooldown", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, CustomOption.CustomOptionType.Impostor, "Trickster Lights Out Cooldown", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, CustomOption.CustomOptionType.Impostor, "Trickster Lights Out Duration", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, CustomOption.CustomOptionType.Impostor, cs(Cleaner.color, "Cleaner"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, CustomOption.CustomOptionType.Impostor, "Cleaner Cooldown", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, CustomOption.CustomOptionType.Impostor, cs(Cleaner.color, "Warlock"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, CustomOption.CustomOptionType.Impostor, "Warlock Cooldown", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, CustomOption.CustomOptionType.Impostor, "Warlock Root Time", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, CustomOption.CustomOptionType.Impostor, cs(BountyHunter.color, "Bounty Hunter"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, CustomOption.CustomOptionType.Impostor, "Duration After Which Bounty Changes",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, CustomOption.CustomOptionType.Impostor, "Cooldown After Killing Bounty", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, CustomOption.CustomOptionType.Impostor, "Additional Cooldown After Killing Others", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, CustomOption.CustomOptionType.Impostor, "Show Arrow Pointing Towards The Bounty", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, CustomOption.CustomOptionType.Impostor, "Arrow Update Intervall", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, CustomOption.CustomOptionType.Impostor, cs(Witch.color, "Witch"), rates, null, true);
            witchCooldown = CustomOption.Create(371, CustomOption.CustomOptionType.Impostor, "Witch Spell Casting Cooldown", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, CustomOption.CustomOptionType.Impostor, "Witch Additional Cooldown", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, CustomOption.CustomOptionType.Impostor, "Witch Can Spell Anyone", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, CustomOption.CustomOptionType.Impostor, "Spell Casting Duration", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, CustomOption.CustomOptionType.Impostor, "Trigger Both Cooldowns", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, CustomOption.CustomOptionType.Impostor, "Voting The Witch Saves All The Targets", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, CustomOption.CustomOptionType.Impostor, cs(Ninja.color, "Ninja"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, CustomOption.CustomOptionType.Impostor, "Ninja Mark Cooldown", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, CustomOption.CustomOptionType.Impostor, "Ninja Knows Location Of Target", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, CustomOption.CustomOptionType.Impostor, "Trace Duration", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, CustomOption.CustomOptionType.Impostor, "Time Till Trace Color Has Faded", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, CustomOption.CustomOptionType.Impostor, "Time The Ninja Is Invisible", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            bomberSpawnRate = CustomOption.Create(460, CustomOption.CustomOptionType.Impostor, cs(Bomber.color, "Bomber"), rates, null, true);
            bomberBombDestructionTime = CustomOption.Create(461, CustomOption.CustomOptionType.Impostor, "Bomb Destruction Time", 20f, 2.5f, 120f, 2.5f, bomberSpawnRate);
            bomberBombDestructionRange = CustomOption.Create(462, CustomOption.CustomOptionType.Impostor, "Bomb Destruction Range", 50f, 5f, 150f, 5f, bomberSpawnRate);
            bomberBombHearRange = CustomOption.Create(463, CustomOption.CustomOptionType.Impostor, "Bomb Hear Range", 60f, 5f, 150f, 5f, bomberSpawnRate);
            bomberDefuseDuration = CustomOption.Create(464, CustomOption.CustomOptionType.Impostor, "Bomb Defuse Duration", 3f, 0.5f, 30f, 0.5f, bomberSpawnRate);
            bomberBombCooldown = CustomOption.Create(465, CustomOption.CustomOptionType.Impostor, "Bomb Cooldown", 15f, 2.5f, 30f, 2.5f, bomberSpawnRate);
            bomberBombActiveAfter = CustomOption.Create(466, CustomOption.CustomOptionType.Impostor, "Bomb Is Active After", 3f, 0.5f, 15f, 0.5f, bomberSpawnRate);

            guesserSpawnRate = CustomOption.Create(310, CustomOption.CustomOptionType.Neutral, cs(Guesser.color, "Guesser"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, CustomOption.CustomOptionType.Neutral, "Chance That The Guesser Is An Impostor", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, CustomOption.CustomOptionType.Neutral, "Guesser Number Of Shots", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, CustomOption.CustomOptionType.Neutral, "Guesser Can Shoot Multiple Times Per Meeting", false, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315, CustomOption.CustomOptionType.Neutral, "Guesses Ignore The Medic Shield", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316, CustomOption.CustomOptionType.Neutral, "Evil Guesser Can Guess The Spy", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, CustomOption.CustomOptionType.Neutral, "Both Guesser Spawn Rate", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, CustomOption.CustomOptionType.Neutral, "Guesser Can't Guess Snitch When Tasks Completed", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, CustomOption.CustomOptionType.Neutral, cs(BetterOtherRoles.Jester.color, "Jester"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, CustomOption.CustomOptionType.Neutral, "Jester Can Call Emergency Meeting", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, CustomOption.CustomOptionType.Neutral, "Jester Has Impostor Vision", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, CustomOption.CustomOptionType.Neutral, cs(Arsonist.color, "Arsonist"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, CustomOption.CustomOptionType.Neutral, "Arsonist Cooldown", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, CustomOption.CustomOptionType.Neutral, "Arsonist Douse Duration", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, CustomOption.CustomOptionType.Neutral, cs(Jackal.color, "Jackal"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, CustomOption.CustomOptionType.Neutral, "Jackal/Sidekick Kill Cooldown", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, CustomOption.CustomOptionType.Neutral, "Jackal Create Sidekick Cooldown", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, CustomOption.CustomOptionType.Neutral, "Jackal Can Use Vents", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, CustomOption.CustomOptionType.Neutral, "Jackal Can Create A Sidekick", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, CustomOption.CustomOptionType.Neutral, "Sidekick Gets Promoted To Jackal On Jackal Death", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, CustomOption.CustomOptionType.Neutral, "Sidekick Can Kill", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, CustomOption.CustomOptionType.Neutral, "Sidekick Can Use Vents", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, CustomOption.CustomOptionType.Neutral, "Jackals Promoted From Sidekick Can Create A Sidekick", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, CustomOption.CustomOptionType.Neutral, "Jackals Can Make An Impostor To His Sidekick", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, CustomOption.CustomOptionType.Neutral, "Jackal And Sidekick Have Impostor Vision", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, CustomOption.CustomOptionType.Neutral, cs(Vulture.color, "Vulture"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, CustomOption.CustomOptionType.Neutral, "Vulture Cooldown", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, CustomOption.CustomOptionType.Neutral, "Number Of Corpses Needed To Be Eaten", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, CustomOption.CustomOptionType.Neutral, "Vulture Can Use Vents", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, CustomOption.CustomOptionType.Neutral, "Show Arrows Pointing Towards The Corpses", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, CustomOption.CustomOptionType.Neutral, cs(Lawyer.color, "Lawyer"), rates, null, true);
            lawyerIsProsecutorChance = CustomOption.Create(358, CustomOption.CustomOptionType.Neutral, "Chance That The Lawyer Is Prosecutor", rates, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, CustomOption.CustomOptionType.Neutral, "Vision", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, CustomOption.CustomOptionType.Neutral, "Lawyer/Prosecutor Knows Target Role", false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, CustomOption.CustomOptionType.Neutral, "Lawyer/Prosecutor Can Call Emergency Meeting", true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, CustomOption.CustomOptionType.Neutral, "Lawyer Target Can Be The Jester", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, CustomOption.CustomOptionType.Neutral, "Pursuer Blank Cooldown", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, CustomOption.CustomOptionType.Neutral, "Pursuer Number Of Blanks", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Mayor.color, "Mayor"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, CustomOption.CustomOptionType.Crewmate, "Mayor Can See Vote Colors", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, CustomOption.CustomOptionType.Crewmate, "Completed Tasks Needed To See Vote Colors", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, CustomOption.CustomOptionType.Crewmate, "Mobile Emergency Button", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, CustomOption.CustomOptionType.Crewmate, "Number Of Remote Meetings", 1f, 1f, 5f, 1f, mayorMeetingButton);
            mayorChooseSingleVote = CustomOption.Create(85, CustomOption.CustomOptionType.Crewmate, "Mayor Can Choose Single Vote", new string[] { "Off", "On (Before Voting)", "On (Until Meeting Ends)" }, mayorSpawnRate);

            engineerSpawnRate = CustomOption.Create(90, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Engineer.color, "Engineer"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, CustomOption.CustomOptionType.Crewmate, "Number Of Sabotage Fixes", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, CustomOption.CustomOptionType.Crewmate, "Impostors See Vents Highlighted", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, CustomOption.CustomOptionType.Crewmate, "Jackal and Sidekick See Vents Highlighted ", true, engineerSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Sheriff.color, "Sheriff"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, CustomOption.CustomOptionType.Crewmate, "Sheriff Cooldown", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, CustomOption.CustomOptionType.Crewmate, "Sheriff Can Kill Neutrals", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, CustomOption.CustomOptionType.Crewmate, "Sheriff Has A Deputy", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, CustomOption.CustomOptionType.Crewmate, "Deputy Number Of Handcuffs", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, CustomOption.CustomOptionType.Crewmate, "Handcuff Cooldown", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, CustomOption.CustomOptionType.Crewmate, "Handcuff Duration", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, CustomOption.CustomOptionType.Crewmate, "Sheriff And Deputy Know Each Other ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, CustomOption.CustomOptionType.Crewmate, "Deputy Gets Promoted To Sheriff", new string[] { "Off", "On (Immediately)", "On (After Meeting)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, CustomOption.CustomOptionType.Crewmate, "Deputy Keeps Handcuffs When Promoted", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Lighter.color, "Lighter"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, CustomOption.CustomOptionType.Crewmate, "Vision On Lights On", 1.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, CustomOption.CustomOptionType.Crewmate, "Vision On Lights Off", 0.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterFlashlightWidth = CustomOption.Create(113, CustomOption.CustomOptionType.Crewmate, "Flashlight Width", 0.3f, 0.1f, 1f, 0.1f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Detective.color, "Detective"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, CustomOption.CustomOptionType.Crewmate, "Anonymous Footprints", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, CustomOption.CustomOptionType.Crewmate, "Footprint Intervall", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, CustomOption.CustomOptionType.Crewmate, "Footprint Duration", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, CustomOption.CustomOptionType.Crewmate, "Time Where Detective Reports Will Have Name", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, CustomOption.CustomOptionType.Crewmate, "Time Where Detective Reports Will Have Color Type", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, CustomOption.CustomOptionType.Crewmate, cs(TimeMaster.color, "Time Master"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, CustomOption.CustomOptionType.Crewmate, "Time Master Cooldown", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, CustomOption.CustomOptionType.Crewmate, "Rewind Time", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, CustomOption.CustomOptionType.Crewmate, "Time Master Shield Duration", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140, CustomOption.CustomOptionType.Crewmate, cs(Medic.color, "Medic"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, CustomOption.CustomOptionType.Crewmate, "Show Shielded Player", new string[] {"Everyone", "Shielded + Medic", "Medic"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, CustomOption.CustomOptionType.Crewmate, "Shielded Player Sees Murder Attempt", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, CustomOption.CustomOptionType.Crewmate, "Shield Will Be Activated", new string[] { "Instantly", "Instantly, Visible\nAfter Meeting", "After Meeting" }, medicSpawnRate);

            medicShowAttemptToMedic = CustomOption.Create(146, CustomOption.CustomOptionType.Crewmate, "Medic Sees Murder Attempt On Shielded Player", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, CustomOption.CustomOptionType.Crewmate, cs(Swapper.color, "Swapper"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, CustomOption.CustomOptionType.Crewmate, "Swapper Can Call Emergency Meeting", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, CustomOption.CustomOptionType.Crewmate, "Swapper Can Only Swap Others", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, CustomOption.CustomOptionType.Crewmate, "Initial Swap Charges", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, CustomOption.CustomOptionType.Crewmate, "Number Of Tasks Needed For Recharging", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, CustomOption.CustomOptionType.Crewmate, cs(Seer.color, "Seer"), rates, null, true);
            seerMode = CustomOption.Create(161, CustomOption.CustomOptionType.Crewmate, "Seer Mode", new string[]{ "Show Death Flash + Souls", "Show Death Flash", "Show Souls"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, CustomOption.CustomOptionType.Crewmate, "Seer Limit Soul Duration", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, CustomOption.CustomOptionType.Crewmate, "Seer Soul Duration", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, CustomOption.CustomOptionType.Crewmate, cs(Hacker.color, "Hacker"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, CustomOption.CustomOptionType.Crewmate, "Hacker Cooldown", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, CustomOption.CustomOptionType.Crewmate, "Hacker Duration", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, CustomOption.CustomOptionType.Crewmate, "Hacker Only Sees Color Type", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, CustomOption.CustomOptionType.Crewmate, "Max Mobile Gadget Charges", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, CustomOption.CustomOptionType.Crewmate, "Number Of Tasks Needed For Recharging", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, CustomOption.CustomOptionType.Crewmate, "Cant Move During Mobile Gadget Duration", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, CustomOption.CustomOptionType.Crewmate, cs(Tracker.color, "Tracker"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, CustomOption.CustomOptionType.Crewmate, "Tracker Update Intervall", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, CustomOption.CustomOptionType.Crewmate, "Tracker Reset Target After Meeting", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, CustomOption.CustomOptionType.Crewmate, "Tracker Can Track Corpses", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, CustomOption.CustomOptionType.Crewmate, "Corpses Tracking Cooldown", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, CustomOption.CustomOptionType.Crewmate, "Corpses Tracking Duration", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
                           
            snitchSpawnRate = CustomOption.Create(210, CustomOption.CustomOptionType.Crewmate, cs(Snitch.color, "Snitch"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(219, CustomOption.CustomOptionType.Crewmate, "Task Count Where The Snitch Will Be Revealed", 5f, 0f, 25f, 1f, snitchSpawnRate);
            snitchMode = CustomOption.Create(211, CustomOption.CustomOptionType.Crewmate, "Information Mode", new string[] { "Chat", "Map", "Chat & Map" }, snitchSpawnRate);
            snitchTargets = CustomOption.Create(212, CustomOption.CustomOptionType.Crewmate, "Targets", new string[] { "All Evil Players", "Killing Players" }, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, CustomOption.CustomOptionType.Crewmate, cs(Spy.color, "Spy"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, CustomOption.CustomOptionType.Crewmate, "Spy Can Die To Sheriff", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, CustomOption.CustomOptionType.Crewmate, "Impostors Can Kill Anyone If There Is A Spy", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, CustomOption.CustomOptionType.Crewmate, "Spy Can Enter Vents", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, CustomOption.CustomOptionType.Crewmate, "Spy Has Impostor Vision", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, CustomOption.CustomOptionType.Crewmate, cs(BetterOtherRoles.Portalmaker.color, "Portalmaker"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, CustomOption.CustomOptionType.Crewmate, "Portalmaker Cooldown", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, CustomOption.CustomOptionType.Crewmate, "Use Portal Cooldown", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, CustomOption.CustomOptionType.Crewmate, "Portalmaker Log Only Shows Color Type", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, CustomOption.CustomOptionType.Crewmate, "Log Shows Time", true, portalmakerSpawnRate);
            portalmakerCanPortalFromAnywhere = CustomOption.Create(395, CustomOption.CustomOptionType.Crewmate, "Can Port To Portal From Everywhere", true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, CustomOption.CustomOptionType.Crewmate, cs(SecurityGuard.color, "Security Guard"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, CustomOption.CustomOptionType.Crewmate, "Security Guard Cooldown", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, CustomOption.CustomOptionType.Crewmate, "Security Guard Number Of Screws", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, CustomOption.CustomOptionType.Crewmate, "Number Of Screws Per Cam", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, CustomOption.CustomOptionType.Crewmate, "Number Of Screws Per Vent", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, CustomOption.CustomOptionType.Crewmate, "Security Guard Duration", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, CustomOption.CustomOptionType.Crewmate, "Gadget Max Charges", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, CustomOption.CustomOptionType.Crewmate, "Number Of Tasks Needed For Recharging", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, CustomOption.CustomOptionType.Crewmate, "Cant Move During Cam Duration", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, CustomOption.CustomOptionType.Crewmate, cs(Medium.color, "Medium"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, CustomOption.CustomOptionType.Crewmate, "Medium Questioning Cooldown", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, CustomOption.CustomOptionType.Crewmate, "Medium Questioning Duration", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, CustomOption.CustomOptionType.Crewmate, "Each Soul Can Only Be Questioned Once", false, mediumSpawnRate);
            mediumChanceAdditionalInfo = CustomOption.Create(364, CustomOption.CustomOptionType.Crewmate, "Chance That The Answer Contains \n    Additional Information", rates, mediumSpawnRate);

            thiefSpawnRate = CustomOption.Create(400, CustomOption.CustomOptionType.Neutral, cs(Thief.color, "Thief"), rates, null, true);
            thiefCooldown = CustomOption.Create(401, CustomOption.CustomOptionType.Neutral, "Thief Cooldown", 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, CustomOption.CustomOptionType.Neutral, "Thief Can Kill Sheriff", true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, CustomOption.CustomOptionType.Neutral, "Thief Has Impostor Vision", true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, CustomOption.CustomOptionType.Neutral, "Thief Can Use Vents", true, thiefSpawnRate);
            thiefCanStealWithGuess = CustomOption.Create(405, CustomOption.CustomOptionType.Neutral, "Thief Can Guess To Steal A Role (If Guesser)", false, thiefSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, CustomOption.CustomOptionType.Crewmate, cs(Trapper.color, "Trapper"), rates, null, true);
            trapperCooldown = CustomOption.Create(420, CustomOption.CustomOptionType.Crewmate, "Trapper Cooldown", 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, CustomOption.CustomOptionType.Crewmate, "Max Traps Charges", 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, CustomOption.CustomOptionType.Crewmate, "Number Of Tasks Needed For Recharging", 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, CustomOption.CustomOptionType.Crewmate, "Trap Needed Trigger To Reveal", 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, CustomOption.CustomOptionType.Crewmate, "Show Anonymous Map", false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, CustomOption.CustomOptionType.Crewmate, "Trap Information Type", new string[] { "Role", "Good/Evil Role", "Name" }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, CustomOption.CustomOptionType.Crewmate, "Trap Duration", 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Hide After Death Modifiers"), true, null, true);

            modifierBloody = CustomOption.Create(1000, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Bloody"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Bloody Quantity"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, CustomOption.CustomOptionType.Modifier, "Trail Duration", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Anti Teleport"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Anti Teleport Quantity"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Tie Breaker"), rates, null, true);

            modifierBait = CustomOption.Create(1030, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Bait"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Bait Quantity"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, CustomOption.CustomOptionType.Modifier, "Bait Report Delay Min", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, CustomOption.CustomOptionType.Modifier, "Bait Report Delay Max", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, CustomOption.CustomOptionType.Modifier, "Warn The Killer With A Flash", true, modifierBait);

            modifierLover = CustomOption.Create(1040, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Lovers"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, CustomOption.CustomOptionType.Modifier, "Chance That One Lover Is Impostor", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, CustomOption.CustomOptionType.Modifier, "Both Lovers Die", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, CustomOption.CustomOptionType.Modifier, "Enable Lover Chat", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Sunglasses"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Sunglasses Quantity"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, CustomOption.CustomOptionType.Modifier, "Vision With Sunglasses", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Mini"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, CustomOption.CustomOptionType.Modifier, "Mini Growing Up Duration", 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, CustomOption.CustomOptionType.Modifier, "Mini Grows Up In Meeting", true, modifierMini);

            modifierVip = CustomOption.Create(1070, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "VIP Quantity"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, CustomOption.CustomOptionType.Modifier, "Show Team Color", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Invert"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Modifier Quantity"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, CustomOption.CustomOptionType.Modifier, "Number Of Meetings Inverted", 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Chameleon"), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Chameleon Quantity"), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, CustomOption.CustomOptionType.Modifier, "Time Until Fading Starts", 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, CustomOption.CustomOptionType.Modifier, "Fade Duration", 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, CustomOption.CustomOptionType.Modifier, "Minimum Visibility", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, CustomOption.CustomOptionType.Modifier, cs(Color.yellow, "Shifter"), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, CustomOption.CustomOptionType.Guesser, cs(Guesser.color, "Number of Crew Guessers"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, CustomOption.CustomOptionType.Guesser, cs(Guesser.color, "Number of Neutral Guessers"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, CustomOption.CustomOptionType.Guesser, cs(Guesser.color, "Number of Impostor Guessers"), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, CustomOption.CustomOptionType.Guesser, "Force Jackal Guesser", false, null, true);
            guesserGamemodeSidekickIsAlwaysGuesser = CustomOption.Create(2012, CustomOption.CustomOptionType.Guesser, "Sidekick Is Always Guesser", false, null);
            guesserForceThiefGuesser = CustomOption.Create(2011, CustomOption.CustomOptionType.Guesser, "Force Thief Guesser", false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, CustomOption.CustomOptionType.Guesser, "Guessers Can Have A Modifier", true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, CustomOption.CustomOptionType.Guesser, "Guesser Number Of Shots", 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, CustomOption.CustomOptionType.Guesser, "Guesser Can Shoot Multiple Times Per Meeting", false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, CustomOption.CustomOptionType.Guesser, "Guesses Ignore The Medic Shield", true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, CustomOption.CustomOptionType.Guesser, "Evil Guesser Can Guess The Spy", true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, CustomOption.CustomOptionType.Guesser, "Guesser Can't Guess Snitch When Tasks Completed", true, null);
            // Care: 2012 already taken!
            

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Map"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map"}, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Number Of Hunters"), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Kill Cooldown"), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Hunter Vision"), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Hunted Vision"), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Common Tasks"), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Short Tasks"), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Long Tasks"), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Timer In Min"), 5f, 1f, 30f, 0.5f);
            hideNSeekTaskWin = CustomOption.Create(3004, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Task Win Is Possible"), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Finish Tasks Punish In Sec"), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Enable Sabotages"), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, CustomOption.CustomOptionType.HideNSeekMain, cs(Color.yellow, "Time The Hunter Needs To Wait"), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Light Cooldown"), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Light Duration"), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Light Vision"), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Light Punish In Sec"), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Admin Cooldown"), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Admin Duration"), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Admin Punish In Sec"), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Arrow Cooldown"), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Arrow Duration"), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.red, "Hunter Arrow Punish In Sec"), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.gray, "Hunted Shield Cooldown"), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.gray, "Hunted Shield Duration"), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.gray, "Hunted Rewind Time"), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, CustomOption.CustomOptionType.HideNSeekRoles, cs(Color.gray, "Hunted Shield Number"), 3f, 1f, 15f, 1f);

            // Prop Hunt General Options
            propHuntMap = CustomOption.Create(4020, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Map"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map"}, null, true, onChange: ()=> { int map = propHuntMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map;});
            propHuntTimer = CustomOption.Create(4021, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Timer In Min"), 5f, 1f, 30f, 0.5f);
            propHuntUnstuckCooldown = CustomOption.Create(4011, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Unstuck Cooldown"), 30f, 2.5f, 60f, 2.5f);
            propHuntUnstuckDuration = CustomOption.Create(4012, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Unstuck Duration"), 2f, 1f, 60f, 1f);
            propHunterVision = CustomOption.Create(4006, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Hunter Vision"), 0.5f, 0.25f, 2f, 0.25f);
            propVision = CustomOption.Create(4007, CustomOption.CustomOptionType.PropHunt, cs(Color.yellow, "Prop Vision"), 2f, 0.25f, 5f, 0.25f);
            // Hunter Options
            propHuntNumberOfHunters = CustomOption.Create(4000, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Number Of Hunters"), 1f, 1f, 5f, 1f, null, true);
            hunterInitialBlackoutTime = CustomOption.Create(4001, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Hunter Initial Blackout Duration"), 10f, 5f, 20f, 1f);
            hunterMissCooldown = CustomOption.Create(4004, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Kill Cooldown After Miss"), 10f, 2.5f, 60f, 2.5f);
            hunterHitCooldown = CustomOption.Create(4005, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Kill Cooldown After Hit"), 10f, 2.5f, 60f, 2.5f);
            propHuntRevealCooldown = CustomOption.Create(4008, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Reveal Prop Cooldown"), 30f, 10f, 90f, 2.5f);
            propHuntRevealDuration = CustomOption.Create(4009, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Reveal Prop Duration"), 5f, 1f, 60f, 1f);
            propHuntRevealPunish = CustomOption.Create(4010, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Reveal Time Punish"), 10f, 0f, 1800f, 5f);
            propHuntAdminCooldown = CustomOption.Create(4022, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Hunter Admin Cooldown"), 30f, 2.5f, 1800f, 2.5f);
            propHuntFindCooldown = CustomOption.Create(4023, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Find Cooldown"), 60f, 2.5f, 1800f, 2.5f);
            propHuntFindDuration = CustomOption.Create(4024, CustomOption.CustomOptionType.PropHunt, cs(Color.red, "Find Duration"), 5f, 1f, 15f, 1f);
            // Prop Options
            propBecomesHunterWhenFound = CustomOption.Create(4003, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Props Become Hunters When Found"), false, null, true);
            propHuntInvisEnabled = CustomOption.Create(4013, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Invisibility Enabled"), true, null, true);
            propHuntInvisCooldown = CustomOption.Create(4014, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Invisibility Cooldown"), 120f, 10f, 1800f, 2.5f, propHuntInvisEnabled);
            propHuntInvisDuration = CustomOption.Create(4015, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Invisibility Duration"), 5f, 1f, 30f, 1f, propHuntInvisEnabled);
            propHuntSpeedboostEnabled = CustomOption.Create(4016, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Speedboost Enabled"), true, null, true);
            propHuntSpeedboostCooldown = CustomOption.Create(4017, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Speedboost Cooldown"), 60f, 2.5f, 1800f, 2.5f, propHuntSpeedboostEnabled);
            propHuntSpeedboostDuration = CustomOption.Create(4018, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Speedboost Duration"), 5f, 1f, 15f, 1f, propHuntSpeedboostEnabled);
            propHuntSpeedboostSpeed = CustomOption.Create(4019, CustomOption.CustomOptionType.PropHunt, cs(Palette.CrewmateBlue, "Speedboost Ratio"), 2f, 1.25f, 5f, 0.25f, propHuntSpeedboostEnabled);



            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, CustomOption.CustomOptionType.General, "Number Of Meetings (excluding Mayor meeting)", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, CustomOption.CustomOptionType.General, "Block Skipping In Emergency Meetings", false);
            noVoteIsSelfVote = CustomOption.Create(5, CustomOption.CustomOptionType.General, "No Vote Is Self Vote", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, CustomOption.CustomOptionType.General, "Hide Player Names", false);
            allowParallelMedBayScans = CustomOption.Create(7, CustomOption.CustomOptionType.General, "Allow Parallel MedBay Scans", false);
            shieldFirstKill = CustomOption.Create(8, CustomOption.CustomOptionType.General, "Shield Last Game First Kill", false);
            finishTasksBeforeHauntingOrZoomingOut = CustomOption.Create(9, CustomOption.CustomOptionType.General, "Finish Tasks Before Haunting Or Zooming Out", true);
            camsNightVision = CustomOption.Create(11, CustomOption.CustomOptionType.General, "Cams Switch To Night Vision If Lights Are Off", false, null, true);
            camsNoNightVisionIfImpVision = CustomOption.Create(12, CustomOption.CustomOptionType.General, "Impostor Vision Ignores Night Vision Cams", false, camsNightVision, false);


            dynamicMap = CustomOption.Create(500, CustomOption.CustomOptionType.General, "Play On A Random Map", false, null, true);
            dynamicMapEnableSkeld = CustomOption.Create(501, CustomOption.CustomOptionType.General, "Skeld", rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, CustomOption.CustomOptionType.General, "Mira", rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, CustomOption.CustomOptionType.General, "Polus", rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, CustomOption.CustomOptionType.General, "Airship", rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, CustomOption.CustomOptionType.General, "Fungle", rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, CustomOption.CustomOptionType.General, "Submerged", rates, dynamicMap, false);
            dynamicMapSeparateSettings = CustomOption.Create(509, CustomOption.CustomOptionType.General, "Use Random Map Setting Presets", false, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
