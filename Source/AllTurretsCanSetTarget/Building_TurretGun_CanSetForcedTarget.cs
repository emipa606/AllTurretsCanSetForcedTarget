using HarmonyLib;
using RimWorld;

namespace BaalEvan.AllTurretsCanSetForcedTarget;

[HarmonyPatch(typeof(Building_TurretGun), "get_CanSetForcedTarget")]
internal static class Building_TurretGun_CanSetForcedTarget
{
    private static void Postfix(ref bool __result)
    {
        __result = true;
    }
}