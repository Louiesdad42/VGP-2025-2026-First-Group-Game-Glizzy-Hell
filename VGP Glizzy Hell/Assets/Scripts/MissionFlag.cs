/************************************
 * File name: MissionFlag.cs
 * Author: Zach Stout
 * Digipen email: zachary.stout@digipen.edu
 * Course: GAM100
 *
 * Description: If the player collides with
 * this object, set the win screen on and 
 * stop the games time
 ************************************/

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
