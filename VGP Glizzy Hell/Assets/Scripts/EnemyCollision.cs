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
