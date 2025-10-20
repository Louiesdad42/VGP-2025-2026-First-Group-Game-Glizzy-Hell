using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] Rigidbody2D Projectile;
    [SerializeField] float SecondsBetweenSpawns;
    [SerializeField] float XSpeed;
    [SerializeField] float YSpeed;
    float DeltaTracker = 0.0f;
    public GameObject spawnerMonster;

    // Update is called once per frame
    void Update()
    {
        if (spawnerMonster)
        {
            DeltaTracker += Time.deltaTime;
            if (DeltaTracker >= SecondsBetweenSpawns)
            {
                DeltaTracker = 0.0f;
                Rigidbody2D clone = Instantiate(Projectile, transform);
                clone.velocity = new Vector2(XSpeed, YSpeed);
            }
        }
    }
}
