using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RilixHalloweenChallenge
{
    public class InfoPanel : MonoBehaviour
    {
        [SerializeField] private Text velocity;
        [SerializeField] private Text progress;
        [SerializeField] private Text time;
        [SerializeField] private SplineFollower splineFollower;

        // Update is called once per frame
        void Update()
        {
            velocity.text = $"Velocidade: {splineFollower.followSpeed:F0}Km/H";
            progress.text = $"Progresso: {splineFollower.result.percent * 100:F1}%";
            time.text = $"Horário: {Mathf.Lerp(17, 24, (float)splineFollower.result.percent):F0}H";
        }
    }
}
