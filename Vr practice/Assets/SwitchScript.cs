using UnityEngine;
using UnityEngine.UI;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] private GameObject Beater;
    private bool flag = true;
    public void beaterSwitch()
    {
        Beater.SetActive(flag);
        flag = !flag;
    }
}
