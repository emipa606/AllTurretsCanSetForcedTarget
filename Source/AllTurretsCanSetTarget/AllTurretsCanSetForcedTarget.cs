using System.Reflection;
using HarmonyLib;
using Verse;

namespace BaalEvan.AllTurretsCanSetForcedTarget;

[StaticConstructorOnStartup]
public static class AllTurretsCanSetForcedTarget
{
    static AllTurretsCanSetForcedTarget()
    {
        new Harmony("BaalEvan.AllTurretsCanSetForcedTarget").PatchAll(Assembly.GetExecutingAssembly());
    }
}