using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RilixHalloweenChallenge
{
    public class RollercoasterVelocity : MonoBehaviour
    {
        [SerializeField] private SplineFollower splineFollower;
        [SerializeField] private FloatVariable accelerationRate;
        [SerializeField] private FloatVariable minSpeed, maxSpeed;
        private SplineComputer splineComputer;
        private SplineSample sample;
        private float acceleration = 0f;
        private float speed=0;

        void Start()
        {
            // Get the SplineComputer from the SplineFollower
            splineComputer = splineFollower.spline;
            speed = splineFollower.followSpeed;
        }

        void Update()
        {
            // Get the current position of the follower on the spline (normalized, 0 to 1)
            double followerPosition = splineFollower.result.percent;

            // Evaluate the spline at the follower's current position
            sample = splineComputer.Evaluate(followerPosition);

            // Get the direction (tangent) vector from the sample
            Vector3 tangent = sample.forward;

            //Calculate angles based on the tangent
            //Pitch angle relative to the horizontal XZ plane
            float pitch = Mathf.Atan2(tangent.y, new Vector2(tangent.x, tangent.z).magnitude) * Mathf.Rad2Deg;

            acceleration = pitch * accelerationRate.Value * Time.deltaTime * 0.01f;
            speed = Mathf.Clamp(splineFollower.followSpeed - acceleration, minSpeed.Value, maxSpeed.Value);
            splineFollower.followSpeed = speed;
        }
    }
}
