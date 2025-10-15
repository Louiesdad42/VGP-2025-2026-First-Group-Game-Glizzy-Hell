using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject player;
    public float speed;

    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
