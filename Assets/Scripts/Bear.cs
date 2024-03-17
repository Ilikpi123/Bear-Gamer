using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    private float speed = 0.05f;
    private Rigidbody BearRB;
    [SerializeField] private Transform Camera;
    void Start()
    {
        BearRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        DoMovement();
    }
    
    void DoMovement()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        BearRB.transform.Translate(-VerticalInput*speed,0,0);
        BearRB.transform.Rotate(0,HorizontalInput,0);
        Camera.Rotate(0, HorizontalInput, 0);
    }
}
