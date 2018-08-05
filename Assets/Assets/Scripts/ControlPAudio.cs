using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPAudio : MonoBehaviour {
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
