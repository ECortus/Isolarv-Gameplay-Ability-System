using System;
using UnityEngine;

namespace IsolarvGAS.Runtime
{
    [CreateAssetMenu(fileName = "NewDirectionalAbilityData", menuName = "Isolarv/Gameplay Ability System/Directional Ability Data", order = 3)]
    public class DirectionalAbilityData : BaseAbilityData
    {
        #region Directional Ability Info

        [Serializable]
        public enum EDirectionalAbilityType
        {
            Projectile,
            Ray
        }

        [SerializeField] private EDirectionalAbilityType directionalAbilityType = EDirectionalAbilityType.Projectile;

        [SerializeField] private AbilityProjectile projectilePrefab;
        [SerializeField] private float projectileSpeed = 10f;
        [SerializeField] private float projectileFlyingDistance = 50f;
        [SerializeField] private bool projectileIsOneHit = false;
        [SerializeField] private bool projectileAffectsOnRadius = false;
        [SerializeField] private float projectileRadiusOfAffect = 5f;

        [SerializeField] private AbilityRay rayPrefab;
        [SerializeField] private float raySpeed = 10f;
        [SerializeField] private float rayLength = 10f;
        [SerializeField] private float rayWidth = 1f;

        public EDirectionalAbilityType DirectionalAbilityType => directionalAbilityType;

        public AbilityProjectile ProjectilePrefab => projectilePrefab;
        public float ProjectileSpeed => projectileSpeed;
        public float ProjectileFlyingDistance => projectileFlyingDistance;
        public bool ProjectileIsOneHit => projectileIsOneHit;
        public bool ProjectileAffectsOnRadius => projectileAffectsOnRadius;
        public float ProjectileRadiusOfAffect => projectileRadiusOfAffect;

        public AbilityRay RayPrefab => rayPrefab;
        public float RaySpeed => raySpeed;
        public float RayLength => rayLength;
        public float RayWidth => rayWidth;

        #endregion
    }
}