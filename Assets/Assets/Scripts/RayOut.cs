using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayOut : MonoBehaviour {
    public float pressDis;

    //Ryacast
    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray rayPos = new Ray(transform.position, this.gameObject.transform.forward);

        if (Physics.Raycast(rayPos, out hit, pressDis))
        {
            if(Input.GetMouseButtonDown(0))
            {
                hit.transform.SendMessage("HitByRay");
            }
        }
        Debug.DrawRay(transform.position, this.gameObject.transform.forward, Color.green);
    }
}
