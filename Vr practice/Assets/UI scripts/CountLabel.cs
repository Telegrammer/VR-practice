using UnityEngine;
using UnityEngine.UI;

public class CountLabel : MonoBehaviour
{
    [SerializeField] int count;

    public void Start()
    {
        SetText();
    }

    private void SetText()
    {
        gameObject.GetComponent<Text>().text = $"Count: {count}";
    }
    void DecreaseCount()
    {
        --count;
        Debug.Log("EEEEEEEEEEEEEee");
        SetText();
        
    }
}
