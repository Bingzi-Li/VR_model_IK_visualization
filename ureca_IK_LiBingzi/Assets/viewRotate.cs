using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewRotate : MonoBehaviour
{
    public float spinSpeed;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, spinSpeed * Time.deltaTime * Input.GetAxis("Fire3"));
    }
}
