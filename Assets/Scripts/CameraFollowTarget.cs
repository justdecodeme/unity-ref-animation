using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform target;
    Vector3 distance;
    [Range(0f, 10f)]
    public float smoothValue = 2f;

    void Start()
    {
        distance = target.position - transform.position;
    }

    void Update()
    {
        Vector3 currentPos = transform.position;
        Vector3 targetPos = target.position - distance;

        transform.position = Vector3.Lerp(currentPos, targetPos, smoothValue * Time.deltaTime);
    }
}
