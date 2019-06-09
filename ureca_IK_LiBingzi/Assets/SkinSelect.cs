using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelect : MonoBehaviour
{
    //public Material skin1, skin2;
    public GameObject skin;
    public Renderer rend;
    public Transform upperarmR, upperarmL, jointR, jointL, handR, handL;
    public Material material;
    int bit = 1;

    // Start is called before the first frame update
    void Start()
    {
        rend = skin.GetComponent<Renderer>();
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
        if (angleL < 90f)
        {
            //set the material to red
            material.color = Color.red;

        }
        else
        {
            //set the material to blue


            material.color = Color.blue;
        }

        if (angleR < 90f)
        {
            //set the material to red

            material.color = Color.red;

        }
        else
        {
            //set the material to blue

            material.color = Color.blue;
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
        }
          
    }

    
}
