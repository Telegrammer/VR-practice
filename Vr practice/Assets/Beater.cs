using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beater : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private float dx;

    private bool isInAir = true;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        FloorTriger.onTouched += stepOnFloor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isInAir == false)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            isInAir = true;
            Debug.Log("Space key was pressed.");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-dx, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(dx, 0, 0));
        }
    }

    public void stepOnFloor()
    {
        isInAir = false;
    }
}
