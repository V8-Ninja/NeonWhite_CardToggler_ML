using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonWhite_CardToggler_ML
{
    public static class MechController_Patches
    {
    }

    [HarmonyPatch(typeof(MechController), nameof(MechController.OnPickupCard), new Type[] { typeof(PlayerCardData), typeof(int) })]
    public static class OnPickupCard_Patch
    {
        private static bool Prefix(PlayerCardData card, int overrideAmmo = -1)
        {
            bool canPickup = true;

            switch (card.cardID)
            {
                case "MACHINEGUN":
                    canPickup = CT_Globals.prfyEnabled;
                    break;
                case "PISTOL":
                    canPickup = CT_Globals.elvtEnabled;
                    break;
                case "RIFLE":
                    canPickup = CT_Globals.gdspEnabled;
                    break;
                case "UZI":
                    canPickup = CT_Globals.stmpEnabled;
                    break;
                case "SHOTGUN":
                    canPickup = CT_Globals.frblEnabled;
                    break;
                case "ROCKETLAUNCHER":
                    canPickup = CT_Globals.domnEnabled;
                    break;
                case "RAPTURE":
                    canPickup = CT_Globals.bolfEnabled;
                    break;
                default:
                    break;
            }

            return canPickup;
        }
    }

    
    [HarmonyPatch(typeof(MechController), nameof(MechController.ForceSetup))]
    public static class ForceSetup_Patch
    {
        private static void Postfix()
        {
            if (!CT_Globals.ktnaEnabled)
            {
                PlayerCardData fistCard = Singleton<Game>.Instance.GetGameData().GetCard("FISTS");
                RM.mechController.OnPickupCard(fistCard, -1);
            }
        }
    }
}
