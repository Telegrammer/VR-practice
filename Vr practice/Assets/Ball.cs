using System;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [SerializeField] private int count;
    [SerializeField] private Text textCount;

    public void Start()
    {
        SetText();
    }

    private void SetText()
    {
        textCount.text = $"Count: {count}";
    }

    private void OnCollisionEnter(Collision collision)
    {
        DecreaseCount();
    }
    void DecreaseCount()
    {
        --count;
        Debug.Log("EEEEEEEEEEEEEee");
        SetText();

    }
};
