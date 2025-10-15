using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HeartController.health -= 1;
        }
    }
}
