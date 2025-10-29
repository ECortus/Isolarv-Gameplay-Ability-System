using System;
using UnityEngine;

namespace IsolarvGAS.Runtime
{
    [CreateAssetMenu(fileName = "NewPointedAbilityData", menuName = "Isolarv/Gameplay Ability System/Pointed Ability Data", order = 1)]
    public class PointedAbilityData : BaseAbilityData
    {
        #region Pointed Ability Info

        [Serializable]
        public enum EPointedAbilityType
        {
            Instant,
            Projectile
        }

        [SerializeField] private EPointedAbilityType pointedAbilityType = EPointedAbilityType.Instant;

        [SerializeField] private AbilityProjectile projectilePrefab;
        [SerializeField] private float projectileSpeed = 10f;
        [SerializeField] private bool projectileIsOneHit = false;
        [SerializeField] private bool projectileAffectsOnRadius = false;
        [SerializeField] private float projectileRadiusOfAffect = 5f;

        public EPointedAbilityType PointedAbilityType => pointedAbilityType;

        public AbilityProjectile ProjectilePrefab => projectilePrefab;
        public float ProjectileSpeed => projectileSpeed;
        public bool ProjectileIsOneHit => projectileIsOneHit;
        public bool ProjectileAffectsOnRadius => projectileAffectsOnRadius;
        public float ProjectileRadiusOfAffect => projectileRadiusOfAffect;

        #endregion
    }
}