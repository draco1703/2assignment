using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitObserver : MonoBehaviour
{
    private int counter;
    public AudioSource pickUpSound;

    void Start()
    {
        pickUpSound = GetComponent<AudioSource>();
        
        counter = 0;

    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //on collision destroy removes the object
        pickUpSound.Play();
        Destroy(collision.gameObject);
        if (collision.gameObject.name == "enemy")
        {
            Destroy(collision.gameObject);
        }

        counter++;
        print(counter);
    }
}

