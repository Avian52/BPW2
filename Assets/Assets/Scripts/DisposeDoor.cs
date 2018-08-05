using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposeDoor : MonoBehaviour {

    private Animator animator;
    private float waitTime;

    private bool open = false;
    public AudioSource ac;

 private void Start()
    {
        animator = GetComponent<Animator>();
        ac = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(waitTime>0)
        {
            waitTime -= Time.deltaTime;
        }
        print(waitTime);

        if(open == true)
        {
            ac.Play();
        }

        if(open == true && waitTime < 0)
        {
            animator.SetTrigger("openclose");
            open = false;
            waitTime = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(waitTime <= 0)
        {
            ActivDoor();
        }

        waitTime = 3f;
    }

    void ActivDoor()
    {
        animator.SetTrigger("openclose");
        open = true;
    }
}
