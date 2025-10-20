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
