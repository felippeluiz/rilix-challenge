using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeDelayedInvoker : MonoBehaviour
{
    [SerializeField] private UnityEvent _afterDelayedTime;
    [SerializeField] private float _baseTimeToDelay;
    public void InvokeAfterTime(float time)
    {
        StartCoroutine(DelayedTimeResponse(_baseTimeToDelay+time));
    }

    IEnumerator DelayedTimeResponse(float time)
    {
        
        yield return new WaitForSeconds(time);

        _afterDelayedTime?.Invoke();
    }
}
