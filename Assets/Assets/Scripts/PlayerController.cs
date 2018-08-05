using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float walkSpeed;
    public float sideSpeed;



    void Update()
    {
        //Movement
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * sideSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;
        
        transform.Translate(x, 0, z);
    }
}