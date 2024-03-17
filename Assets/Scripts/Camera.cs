using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    private void Start()
    {
    }
    void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(5, 6.5f, 0.1f));


        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
