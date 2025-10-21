/************************************
 * File name: PlayerProjDestroy.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: VGP
 *
 * Description: Destroys the player projectile
 * when it contacts with either a wall or an enemy.
 * If it is an enemy, also delete the enemy.
 ************************************/

using UnityEngine;

public class PlayerProjDestroy : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
