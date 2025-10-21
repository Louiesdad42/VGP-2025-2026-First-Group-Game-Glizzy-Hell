/************************************
 * File name: ProjectileSpawner.cs
 * Author: Zach Stout
 * Digipen email: zachary.stout@digipen.edu
 * Course: GAM100
 *
 * Description: Spawns projectiles out of the 
 * entity that it is attached to in a consistent
 * direction
 ************************************/

using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] Rigidbody2D Projectile;
    [SerializeField] float SecondsBetweenSpawns;
    [SerializeField] float XSpeed;
    [SerializeField] float YSpeed;
    float DeltaTracker = 0.0f;
    public GameObject spawnerMonster;

    // Update is called once per frame
    void Update()
    {   // checks that the spawner even exists before continuing functions
        if (spawnerMonster)
        {
            DeltaTracker += Time.deltaTime;
            if (DeltaTracker >= SecondsBetweenSpawns)
            {
                //setting timer to 0, making projectile, and setting velocity of projectile
                DeltaTracker = 0.0f;
                Rigidbody2D clone = Instantiate(Projectile, transform);
                clone.velocity = new Vector2(XSpeed, YSpeed);
            }
        }
    }
}
