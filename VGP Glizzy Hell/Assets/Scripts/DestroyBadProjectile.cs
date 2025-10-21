/************************************
 * File name: DestroyBadProjectile.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: VGP
 *
 * Description: On collision with anything,
 * the enemy projectile is destroyed.
 ************************************/

using UnityEngine;

public class DestroyBadProjectile : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
