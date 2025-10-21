/*
 * Name: Neha Sankarkumar
 * Date: 10/21/25
 * Desc: This script destroys spawners upon collission with player fire.
 */
using UnityEngine;

public class DestroySpawners : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Condiment"))
        {
            Destroy(gameObject);
        }
    }
}
