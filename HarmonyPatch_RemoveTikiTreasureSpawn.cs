using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(TreasurePointManager), "Start")]
public class HarmonyPatch_RemoveTikiTreasureSpawn
{
    [HarmonyPostfix]
    static void RemoveTikiTreasureSpawn(ref TreasurePointManager __instance)
    {
        foreach (var tls in __instance.treasureLootSettings)
        {
            foreach (var item in tls.lootTable.items)
            {
                bool isTiki = item.obj is SO_RandomizerCategory;
                if (isTiki)
                {
                    item.spawnChance = "0%";
                    item.weight = 0;
                }
            }
        }
    }
}