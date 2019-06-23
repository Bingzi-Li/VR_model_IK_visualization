using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAvatarCtrlMirror : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    public GameObject gameObject2;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        smoothSpeed = 0.9f;
    }


    // Update is called once per frame
    void Update()
    {
        // udpate position of avatar
        Vector3 desiredPos = target.position;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;

        //change the mirror visibility
        rend = gameObject2.GetComponent<Renderer>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rend.enabled == true)
                rend.enabled = false;
            else
                rend.enabled = true;
        }
    }
}
