using UnityEngine;
using HarmonyLib;
using System.Reflection;

public class TikisAreNotMadeOfMetal : Mod
{
    private Harmony _harmony;

    public void Start()
    {
        _harmony = new Harmony("st*r.TikisAreNotMadeOfMetal");
        _harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public void OnModUnload()
    {
        _harmony.UnpatchAll(_harmony.Id);
    }
}

