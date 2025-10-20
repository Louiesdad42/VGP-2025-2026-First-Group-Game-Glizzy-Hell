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
