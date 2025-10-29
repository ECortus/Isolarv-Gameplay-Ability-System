using UnityEngine;

namespace IsolarvGAS.Runtime
{
    [CreateAssetMenu(fileName = "NewTargetedAbilityData", menuName = "Isolarv/Gameplay Ability System/Targeted Ability Data", order = 2)]
    public class TargetedAbilityData : PointedAbilityData
    {
        #region Targeted Ability Info  

        [SerializeField] private bool projectileFollowsTarget = false;
        public bool ProjectileFollowsTarget => projectileFollowsTarget;

        #endregion
    }
}