using UnityEngine;

public class MissionFlag : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    private void Start()
    {
        winScreen.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
        }
    }
}
