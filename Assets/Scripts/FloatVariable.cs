using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RilixHalloweenChallenge
{
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "Data/FloatVariable", order = 0)]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private float value;
        public float Value => value;
    }
}
