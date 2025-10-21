/************************************
 * File name: PlayerFire.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: VGP
 *
 * Description: When either the left or right
 * mouse button is clicked, a projectile is fired.
 ************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerFire : MonoBehaviour
{
    [Tooltip("Put prefab to be fired here")]
    public GameObject projectile;
    public GameObject projectile2;
    [Tooltip("The minimum time between firing")]
    public float cooldown = 0.3f;
    private float timer = 0;
    public float projSpeed = 10; //speed of the projectiles

    // Update is called once per frame
    void Update()
    {
        if (timer < cooldown)
        {
            timer += Time.deltaTime; //Adds time to timer
        }
        else if (Input.GetMouseButton(0))
        {
            //calculate direction and fire
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            Fire((mousePos - transform.position).normalized);
            timer = 0;
        }
        else if (Input.GetMouseButton(1))
        {
            //calculate direction and fire
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            Fire2((mousePos - transform.position).normalized);
            timer = 0;
        }
    }

    void Fire(Vector3 direction)
    {
        //create a clone of the prefab and set values
        Vector3 spawnPos = transform.position + direction;
        GameObject clone = Instantiate(projectile, spawnPos, Quaternion.LookRotation(Vector3.forward, direction));
        clone.GetComponent<Rigidbody2D>().velocity = direction * projSpeed;
    }
    void Fire2(Vector3 direction)
    {
        //create a clone of the prefab and set values
        Vector3 spawnPos = transform.position + direction;
        GameObject clone = Instantiate(projectile2, spawnPos, Quaternion.LookRotation(Vector3.forward, direction));
        clone.GetComponent<Rigidbody2D>().velocity = direction * projSpeed;
    }
}
