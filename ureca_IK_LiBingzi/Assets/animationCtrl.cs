using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rBody;
    Animator anim;
void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float speed = rBody.velocity.magnitude;
        if (speed > 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
