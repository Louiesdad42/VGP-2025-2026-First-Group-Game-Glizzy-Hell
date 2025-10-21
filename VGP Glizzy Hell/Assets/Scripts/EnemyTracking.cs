/*
 * Name: Neha Sankarkumar
 * Date: 10/21/25
 * Desc: This script makes the roaming enemies chase the player, and orients them left or right.
 */
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Animator myanimator;

    private void Start()
    {
        myanimator = GetComponent<Animator>();
    }
    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        myanimator.SetFloat("x", direction.x);
    }
}
