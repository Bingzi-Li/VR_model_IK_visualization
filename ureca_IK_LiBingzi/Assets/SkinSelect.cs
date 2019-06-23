using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelect : MonoBehaviour
{
    //public Material skin1, skin2;
    public Material llb, llf, lub, luf, rlb, rlf, rub, ruf;
    public Transform upperarmR, upperarmL, jointR, jointL, handR, handL;

   // int bit = 1;

    // Start is called before the first frame update
    void Start()
    {
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

        // smaller angle, lower back and upper front is strained (redder)
        llb.color = new Color(1, angleL / 180f, angleL / 180f, 1);
        luf.color = new Color(1, angleL / 180f, angleL / 180f, 1);
        rlb.color = new Color(1, angleR / 180f, angleR / 180f, 1);
        ruf.color = new Color(1, angleR / 180f, angleR / 180f, 1);

        // smaller angle, upper back and lower front is relaxed (bluer)
        lub.color = new Color(angleL / 180f, angleL / 180f, 1, 1);
        llf.color = new Color(angleL / 180f, angleL / 180f, 1, 1);
        rub.color = new Color(angleR / 180f, angleR / 180f, 1, 1);
        rlf.color = new Color(angleR / 180f, angleR / 180f, 1, 1);
    }

    
}
