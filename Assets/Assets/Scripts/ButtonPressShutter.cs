using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressShutter : MonoBehaviour {

    public Animator animator;
    public Animator handleAn;
    public AudioSource thisAudioS;
    public AudioSource shutterAudioS;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        thisAudioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(animator == null)
        {
            animator = GetComponentInParent<Animator>();
        }
    }

    void HitByRay()
    {
        animator.SetTrigger("buttonPress");
        handleAn.SetTrigger("buttonPress");
        thisAudioS.Play();
        shutterAudioS.Play();
        Debug.Log("I was hit by a Ray");
    }
}
