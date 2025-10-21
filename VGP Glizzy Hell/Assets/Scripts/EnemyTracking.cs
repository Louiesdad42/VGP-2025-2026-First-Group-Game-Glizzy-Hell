/*
 * File Name: EnemyTracking
 * Author: Neha Sankarkumar
 * Course: VGP
 * 
 * Desc: This script makes the roaming enemies chase the player, 
 * and orients them left or right.
 */
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject player;
    public float speed; // changeable speed of roaming enemies
    public Animator myanimator;

    // Start is called before the first frame update
    private void Start()
    {
        myanimator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        myanimator.SetFloat("x", direction.x); // sets the enemy's direction to face

        // changes the enemy's position based on speed and the player's location
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
