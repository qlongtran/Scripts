//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
using Skua.Core.Interfaces;

public class ChaorrupterUnlocked
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreAdvanced Adv = new CoreAdvanced();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        GetYourSword();

        Core.SetOptions(false);
    }

    public void GetYourSword()
    {
        if (Core.CheckInventory("Chaorrupter Unlocked"))
            return;

        if (Core.IsMember)
            Core.BuyItem("chaoswar", 641, "Chaorrupter Unlocked", shopItemID: 11172);
        else Core.HuntMonster("chaoswar", "High Chaos Knight", "Chaorrupter Unlocked");
        Adv.EnhanceItem("Chaorrupter Unlocked", EnhancementType.Lucky);
    }
}