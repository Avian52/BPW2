using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposerSounds : MonoBehaviour {

    [Header("Teddy sound effects")]
    public AudioClip[] clipsTeddy;

    [Header("Dummy sound effects")]
    public AudioClip[] clipsDummy;

    [Header("Person sound effects")]
    public AudioClip[] clipsPerson;

    private AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "teddy")
        {
            audioS.clip = clipsTeddy[Random.Range(0, clipsTeddy.Length)];
            audioS.Play();
        }

        if (other.tag == "dummy")
        {
            audioS.clip = clipsDummy[Random.Range(0, clipsDummy.Length)];
            audioS.Play();
        }

        if (other.tag == "person")
        {
            audioS.clip = clipsPerson[Random.Range(0, clipsPerson.Length)];
            audioS.Play();
        }
    }
}
