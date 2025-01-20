using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RilixHalloweenChallenge
{
    public class TimeOfDay : MonoBehaviour
    {
        [SerializeField] private float start, end;
        [SerializeField] private SplineFollower splineFollower;

        private void Update()
        {
            SetTimeRatio((float)splineFollower.result.percent);
        }
        private void SetTimeRatio(float ratio)
        {
            var desiredRotation = Mathf.Lerp(start, end, ratio);
            transform.rotation = Quaternion.Euler(desiredRotation, 0, 0);
        }
    }
}
