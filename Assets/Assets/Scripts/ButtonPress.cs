using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

    public Animator animator;
    public Spawner spawner;
    public ControlPannel cp;
    private AudioSource audioS;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        cp = GetComponentInParent<ControlPannel>();
        audioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(animator == null)
        {
            animator = GetComponentInParent<Animator>();
        }
        
        spawner = GetComponentInParent<Spawner>();
    }

    void HitByRay()
    {
        if(gameObject.name == "knop1")
        {
            animator.SetTrigger("buttonPress");
            spawner.B1Pressed();
            cp.but1++;
        }

        if (gameObject.name == "knop2")
        {
            animator.SetTrigger("buttonPress");
            spawner.B2Pressed();
            cp.but2++;
        }

        if (gameObject.name == "knop3")
        {
            animator.SetTrigger("buttonPress");
            spawner.B3Pressed();
            cp.but3++;
        }
        audioS.Play();
        Debug.Log("I was hit by a Ray");
    }
}
