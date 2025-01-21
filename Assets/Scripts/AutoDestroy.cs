using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RilixHalloweenChallenge
{
    public class AutoDestroy : MonoBehaviour
    {
        public void AutoDestroyInSeconds(float seconds)
        {
            StartCoroutine(DestroyAfterTime(seconds));
        }
        IEnumerator DestroyAfterTime(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }
    }
}
