using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
        smoothSpeed = 0.9f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        //transform.position = smoothedPos;
        transform.position = desiredPos;
        offset = transform.position - target.position;

    }
}
