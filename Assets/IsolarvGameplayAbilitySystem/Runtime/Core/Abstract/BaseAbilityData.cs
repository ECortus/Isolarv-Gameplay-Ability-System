using System;
using Unity.Collections;
using UnityEngine;

namespace IsolarvGAS.Runtime
{
    public abstract class BaseAbilityData : ScriptableObject
    {
        #region Actor Info

        [SerializeField] private string id;
        [SerializeField] private string abilityName;
        [SerializeField] private Sprite icon;
        [SerializeField] private string description;

        public string Id => id;
        public string Name => abilityName;
        public Sprite Icon => icon;
        public string Description => description;

        #endregion

        #region Base Affect Info

        [SerializeField] private bool affectOnRadius = false;
        [SerializeField] private float radiusOfAffect = 5f;

        [SerializeField] private bool affectAtSelf = false;
        [SerializeField] private bool affectAtAllies = false;
        [SerializeField] private bool affectAtEnemies = true;

        [SerializeField] private LayerMask affectableLayers = ~0;

        public bool AffectOnRadius => affectOnRadius;
        public float RadiusOfAffect => radiusOfAffect;
        public bool AffectAtSelf => affectAtSelf;
        public bool AffectAtAllies => affectAtAllies;
        public bool AffectAtEnemies => affectAtEnemies;
        public LayerMask AffectableLayers => affectableLayers;

        #endregion

        #region Charges Usages Info

        [SerializeField] private float chargeUsageOnCast = 1f;
        [SerializeField] private float chargeUsageOnHoldPerSecond = 0.1f;

        [SerializeField] private float restoreChargesPerSecond = 1f;
        [SerializeField] private float maxCharges = 3f;

        public float ChargeUsageOnCast => chargeUsageOnCast;
        public float RestoreChargesPerSecond => restoreChargesPerSecond;
        public float MaxCharges => maxCharges;

        public float ChargeUsageOnHoldPerSecond
        {
            get
            {
                if (inputType == EAbilityInputType.Hold)
                    return chargeUsageOnHoldPerSecond;

                return 0f;
            }
        }

        #endregion

        #region Input Info

        [Serializable]
        public enum EAbilityInputType
        {
            Instant,
            Hold
        }

        [SerializeField] private EAbilityInputType inputType = EAbilityInputType.Instant;
        public EAbilityInputType InputType => inputType;

        #endregion

        #region Visual Effects Info

        [SerializeField] private GameObject onPreCastVFX;
        [SerializeField] private GameObject onCastVFX;
        [SerializeField] private GameObject onImpactVFX;

        public GameObject OnPreCastVFX => onPreCastVFX;
        public GameObject OnCastVFX => onCastVFX;
        public GameObject OnImpactVFX => onImpactVFX;

        #endregion

        #region Audio Effects Info

        [SerializeField] private AudioClip onPreCastSFX;
        [SerializeField] private AudioClip onCastSFX;
        [SerializeField] private AudioClip onImpactSFX;

        public AudioClip OnPreCastSFX => onPreCastSFX;
        public AudioClip OnCastSFX => onCastSFX;
        public AudioClip OnImpactSFX => onImpactSFX;

        #endregion
    }
}