using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriger : MonoBehaviour
{
    public static Action onTouched;

    private void OnTriggerEnter(Collider other)
    {
        onTouched?.Invoke();
    }
    private void OnTriggerStay(Collider other)
    {
        onTouched?.Invoke();
    }
}
