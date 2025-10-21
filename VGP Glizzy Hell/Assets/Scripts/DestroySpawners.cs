/*
 * File Name: DestroySpawners
 * Author: Neha Sankarkumar
 * Course: GAM100
 * 
 * Desc: This script destroys spawners upon collission with player fire.
 */
using UnityEngine;

public class DestroySpawners : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // if a 'Condiment' (Ketchup or Mustard prefab) hits the spawner
        if (collision.gameObject.CompareTag("Condiment"))
        {
            Destroy(gameObject);
        }
    }
}
