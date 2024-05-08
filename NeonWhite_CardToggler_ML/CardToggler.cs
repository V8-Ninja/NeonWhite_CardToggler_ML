﻿using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.InputSystem;

namespace NeonWhite_CardToggler_ML
{
    public class CardToggler : MelonMod
    {
        private MelonPreferences_Category inputKeys;

        public override void OnInitializeMelon()
        {
            inputKeys = MelonPreferences.CreateCategory("CT_V8N_InputKeys");

            CT_Globals.toggleKTNA = inputKeys.CreateEntry("ToggleKatana", Key.Digit1);
            CT_Globals.togglePRFY = inputKeys.CreateEntry("TogglePurify", Key.Digit2);
            CT_Globals.toggleELVT = inputKeys.CreateEntry("ToggleElevate", Key.Digit3);
            CT_Globals.toggleGDSP = inputKeys.CreateEntry("ToggleGodspeed", Key.Digit4);
            CT_Globals.toggleSTMP = inputKeys.CreateEntry("ToggleStomp", Key.Digit5);
            CT_Globals.toggleFRBL = inputKeys.CreateEntry("ToggleFireball", Key.Digit6);
            CT_Globals.toggleDOMN = inputKeys.CreateEntry("ToggleDominion", Key.Digit7);
            CT_Globals.toggleBOLF = inputKeys.CreateEntry("ToggleBookOfLife", Key.Digit8);
        }

        public override void OnLateUpdate()
        {
            bool toggledKTNA = Keyboard.current[CT_Globals.toggleKTNA.Value].wasPressedThisFrame;
            bool toggledPRFY = Keyboard.current[CT_Globals.togglePRFY.Value].wasPressedThisFrame;
            bool toggledELVT = Keyboard.current[CT_Globals.toggleELVT.Value].wasPressedThisFrame;
            bool toggledGDSP = Keyboard.current[CT_Globals.toggleGDSP.Value].wasPressedThisFrame;
            bool toggledSTMP = Keyboard.current[CT_Globals.toggleSTMP.Value].wasPressedThisFrame;
            bool toggledFRBL = Keyboard.current[CT_Globals.toggleFRBL.Value].wasPressedThisFrame;
            bool toggledDOMN = Keyboard.current[CT_Globals.toggleDOMN.Value].wasPressedThisFrame;
            bool toggledBOLF = Keyboard.current[CT_Globals.toggleBOLF.Value].wasPressedThisFrame;

            if (toggledKTNA || toggledPRFY || toggledELVT || toggledGDSP || toggledSTMP || toggledFRBL
                || toggledDOMN || toggledBOLF)
            {
                string inputStr = "Input detected!\n\nKTNA: {0}\nPRFY: {1}\nELVT: {2}\nGDSP: {3}\n";
                inputStr += "STMP: {4}\nFRBL: {5}\nDOMN: {6}\nBOLF: {7}\n\n";

                inputStr = string.Format(inputStr, toggledKTNA, toggledPRFY, toggledELVT, toggledGDSP,
                toggledSTMP, toggledFRBL, toggledDOMN, toggledBOLF);

                LoggerInstance.Msg(inputStr);
            }
        }
    }

    public static class CT_Globals
    {
        public static MelonPreferences_Entry<Key> toggleKTNA;
        public static MelonPreferences_Entry<Key> togglePRFY;
        public static MelonPreferences_Entry<Key> toggleELVT;
        public static MelonPreferences_Entry<Key> toggleGDSP;
        public static MelonPreferences_Entry<Key> toggleSTMP;
        public static MelonPreferences_Entry<Key> toggleFRBL;
        public static MelonPreferences_Entry<Key> toggleDOMN;
        public static MelonPreferences_Entry<Key> toggleBOLF;
    }
}
