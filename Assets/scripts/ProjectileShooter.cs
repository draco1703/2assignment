using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;  
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;

            projectile.transform.position = new Vector3() ;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 20; //40 is the speed of the projectile

            Destroy(projectile.gameObject, 3);
        }  
    }
}
