//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/ThroneofDarkness/CoreToD.cs

using Skua.Core.Interfaces;
public class DeathPitBrawlREP
{
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreToD CoreToD = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        //Farm.UseBoost(ChangeToBoostID, Skua.Core.Models.Items.BoostType.Reputation, false);
        CoreToD.DeathPitPVP();
        Farm.DeathPitBrawlREP();

        Core.SetOptions(false);
    }
}
