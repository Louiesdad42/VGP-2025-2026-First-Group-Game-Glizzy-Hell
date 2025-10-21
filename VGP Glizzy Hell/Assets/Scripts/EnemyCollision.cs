/************************************
 * File name: EnemyCollision.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: GAM100
 *
 * Description: On collision with the enemy,
 * subtract 1 from the health value of the health
 * controller script and additionally make sure you
 * are not colliding multiple times at once with the 
 * has collided variable
 ************************************/

using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public bool hascollided = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hascollided == false)
        {
            HeartController.health -= 1;
        }
        hascollided = true;
    }
    void Update()
    {
        hascollided = false;
    }
}
