using Controllers;
using UnityEngine;

namespace LineWars.Model.Game.Nations
{
    public class Russia : INation
    {
        public GameObject GetUnitPrefab(UnitType type)
        {
            switch (type)
            {
                case UnitType.Infrantry:
                    return Resources.Load<GameObject>("Russia/Infrantry");
                default:
                    return Resources.Load<GameObject>("DefaultUnits/BaseInfrantry");;
            }
        }
    }
}