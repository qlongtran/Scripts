﻿//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Story/LordsofChaos/Core13LoC.cs
using Skua.Core.Interfaces;
public class MythsongREP
{
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public Core13LoC LOC => new Core13LoC();
    public CoreAdvanced Adv = new CoreAdvanced();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        LOC.Kimberly();

        //Farm.UseBoost(ChangeToBoostID, Skua.Core.Models.Items.BoostType.Reputation, false);

        Farm.MythsongREP();

        Core.SetOptions(false);
    }
}