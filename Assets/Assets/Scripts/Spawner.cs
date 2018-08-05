using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject teddy;
    public GameObject dummy;
    public GameObject person;

    public Transform spawnPos;

    public void B1Pressed()
    {
        Instantiate<GameObject>(teddy, spawnPos.position, spawnPos.rotation);
    }

    public void B2Pressed()
    {
        Instantiate<GameObject>(dummy, spawnPos.position, spawnPos.rotation);
    }

    public void B3Pressed()
    {
        Instantiate<GameObject>(person, spawnPos.position, spawnPos.rotation);
    }
}
