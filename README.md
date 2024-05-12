# Neon White Card Toggler for MelonLoader

This mod is a re-imeplementation of my **[Neon White Card Toggler mod](https://github.com/V8-Ninja/NeonWhite_CardToggler)** that I made using BepInEx. The larger Neon White community uses MelonLoader for their modding purposes, so I decided to port what I had to that framework.

## How To Use This Mod

1. Download and play Neon White at least once.
2. Download the latest `MelonLoader.Installer.exe` file from the most recent **[MelonLoader release](https://github.com/LavaGang/MelonLoader/releases/latest)**
3. Run the `MelonLoader.Installer.exe` file, selecting "Neon White.exe" as the Unity game and the most stable version of MelonLoader.
   - **NOTE:** As of May 2024, the most stable version of MelonLoader is v0.6.1. The latest MelonLoader framework version (v0.6.2) is considered _unstable._
4. Play Neon White again.
   - If you see a MelonLoader logo or console window appear before Neon White begins playing its intro movies, you have successfully installed the framework.
5. Downloade the DLL file from the most recent release on this repository and place the file in the new "Mods" folder in your Neon White install directory.
6. You are good to go!

## Default Controls

- Keyboard 1 = Toggle whether you start a level with the Katana card.
- Keyboard 2 = Toggle the ability to pick up Purify cards.
- Keyboard 3 = Toggle the ability to pick up Elevate cards.
- Keyboard 4 = Toggle the ability to pick up Godspeed cards.
- Keyboard 5 = Toggle the ability to pick up Stomp cards.
- Keyboard 6 = Toggle the ability to pick up Fireball cards.
- Keyboard 7 = Toggle the ability to pick up Dominion cards.
- Keyboard 8 = Toggle the ability to pick up Book of Life cards.

These default keybindings can be changed by modifying the `../Neon White/UserData/MelonPreferences.cfg` file, specifically the text inside the quotes after the "[CT_V8N_InputKeys]" header. For a full list of acceptable values, check out the **[Key Enum documentation](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/api/UnityEngine.InputSystem.Key.html)** in Unity's Input System module. (Look for the "Name" column on the table underneath the "Fields" header.)

## How To Build

1. Clone the repository.
2. Open the Solution file in Visual Studio 2022 or later.
3. Delete the references to the following DLLs and re-reference them;
   - `../Neon White/MelonLoader/net6/0Harmony.dll`
   - `../Neon White/MelonLoader/net6/MelonLoader.dll`
   - `../Neon White/Neon White_data/Managed/Assembley-CSharp.dll`
   - `../Neon White/Neon White_data/Managed/Unity.InputEngine.dll`
   - `../Neon White/Neon White_data/Managed/UnityEngine.dll`
   - `../Neon White/Neon White_data/Managed/UnityEngine.CoreModule.dll`
4. Right click on the solution name and select the "Build" or "Rebuild" option.

# WARNING

This mod does _**NOT**_ disable saving or uploading scores to the leaderboards. It is **HIGHLY RECOMMENDED** that you back up your original save file and play offline while using this mod. I am not responsible for any actions taken against you by Angel Matrix, Annapurna Interactive, or Valve.
