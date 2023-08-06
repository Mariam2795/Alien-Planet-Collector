using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectPlanet : MonoBehaviour
{
    public AudioSource collectSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 5;
        Destroy(gameObject);
    }
}

