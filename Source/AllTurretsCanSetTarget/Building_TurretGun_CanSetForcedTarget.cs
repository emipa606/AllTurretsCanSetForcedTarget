using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace BaalEvan.AllTurretsCanSetForcedTarget;

[HarmonyPatch]
internal static class Building_TurretGun_CanSetForcedTarget
{
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(Building_TurretGun), "get_CanSetForcedTarget");

        if (!ModsConfig.IsActive("CETeam.CombatExtended"))
        {
            yield break;
        }

        yield return AccessTools.Method(AccessTools.TypeByName("CombatExtended.Building_TurretGunCE"),
            "get_CanSetForcedTarget");
    }

    private static void Postfix(ref bool __result, Building __instance)
    {
        if (__result)
        {
            return;
        }

        if (!__instance.Faction.IsPlayerSafe())
        {
            return;
        }

        __result = true;
    }
}