﻿//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/Nation/CoreNation.cs
using Skua.Core.Interfaces;

public class BambloozevsDrudgen
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreNation Nation = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.BankingBlackList.AddRange(Nation.bagDrops);
        Core.SetOptions();

        MaxBags();

        Core.SetOptions(false);
    }

    public void MaxBags()
    {
        Core.AddDrop(Nation.bagDrops);

        Nation.BambloozevsDrudgen("Diamond of Nulgath", 1000);
        if (Core.CheckInventory("Drudgen the Assistant"))
        {
            while (!Bot.ShouldExit && !Core.CheckInventory("Tainted Gem", 1000))
                Nation.ContractExchange(ChooseReward.TaintedGem);
            while (!Bot.ShouldExit && !Core.CheckInventory("Dark Crystal Shard", 1000))
                Nation.ContractExchange(ChooseReward.DarkCrystalShard);
            while (!Bot.ShouldExit && !Core.CheckInventory("Gem of Nulgath", 300))
                Nation.ContractExchange(ChooseReward.GemofNulgath);
            while (!Bot.ShouldExit && !Core.CheckInventory("Blood Gem of the Archfiend", 100))
                Nation.ContractExchange(ChooseReward.BloodGemoftheArchfiend);
        }
        Nation.BambloozevsDrudgen("Diamond of Nulgath", 1000);
    }
}