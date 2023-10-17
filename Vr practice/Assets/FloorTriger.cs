using System;
using UnityEngine;

public class FloorTriger : MonoBehaviour
{
    public static Action onTouched;
    private void OnTriggerStay(Collider other)
    {
        onTouched?.Invoke();
    }
}
