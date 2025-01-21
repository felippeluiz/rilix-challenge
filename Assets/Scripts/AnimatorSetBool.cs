using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RilixHalloweenChallenge
{
    [RequireComponent(typeof(Animator))]
    public class AnimatorSetBool : MonoBehaviour
    {
        private Animator animator;
        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void SetBoolToTrue(string boolName)
        {
            animator.SetBool(boolName, true);
        }
        public void SetBoolToFalse(string boolName)
        {
            animator.SetBool(boolName, false);
        }
    }
}
