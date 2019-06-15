using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelect : MonoBehaviour
{

    public GameObject llb, llf, lub, luf, rlb, rlf, rub, ruf;
    public Renderer rllb, rllf, rlub, rluf, rrlb, rrlf, rrub, rruf;
    public Transform upperarmR, upperarmL, jointR, jointL, handR, handL;
    int bit = 1;

    // Start is called before the first frame update
    void Start()
    {
        rllb = llb.GetComponent<Renderer>();
        rllf = llf.GetComponent<Renderer>();
        rlub = lub.GetComponent<Renderer>();
        rluf = luf.GetComponent<Renderer>();
        rrlb = rlb.GetComponent<Renderer>();
        rrlf = rlf.GetComponent<Renderer>();
        rrub = rub.GetComponent<Renderer>();
        rruf = ruf.GetComponent<Renderer>();
       
        //rend.enabled = true;
        //rend.material = skin1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 upperarmRPos = upperarmR.position;
        Vector3 upperarmLPos = upperarmL.position;
        Vector3 jointRPos = jointR.position;
        Vector3 jointLPos = jointL.position;
        Vector3 handRPos = handR.position;
        Vector3 handLPos = handL.position;

        float angleL = Vector3.Angle(upperarmLPos - jointLPos, handLPos - jointLPos);
        float angleR = Vector3.Angle(upperarmRPos - jointRPos, handRPos - jointRPos);
        //rend.material.shader = Shader.Find("Shirt01");
        /*if (angleL < 90f)
        {
            //set the material to red
            rllb.material.SetColor('rllb', (0, 0, 1, 1));

        }
        else
        {
            //set the material to blue


        }

        if (angleR < 90f)
        {
            //set the material to red

           
        }
        else
        {
            //set the material to blue

            
        }

        // testing

        if (Input.GetKeyDown(KeyCode.C))
        {
            if(bit == 1)
            {
                //set the material to red
                //rend.material.SetColor("myColor", Color.red);
                material.color = Color.red;
                bit = 0;

            }
            else
            {
                //set the material to blue
                //rend.material.SetColor("myColor", Color.blue);
                material.color = Color.blue;
                bit = 1;
            }
        }*/

        rllb.material.SetColor('rllb', (angleR/180f, angleR/180f, angleR/180f, 1));

    }

    
}
