/************************************
 * File name: HeartController.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: GAM100
 *
 * Description: Sets the different cases for
 * health, with each case having a different amount
 * of hearts active and the last case stopping the game
 ************************************/

using UnityEngine;

public class HeartController : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets default state
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            //makes sure health is not over its supposed value
            health = 3;
        }
        switch (health)
        {
            case 3:
                //max health case
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                //when hit once case
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                //when hit twice case
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                //death case
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0; //stops the player from doing much anything else
                break;
        }
    }
}
