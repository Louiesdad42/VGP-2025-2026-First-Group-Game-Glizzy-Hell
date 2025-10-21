/************************************
 * File name: CameraFollow.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: GAM100
 *
 * Description: Allows the camer to follow
 * the player and allows the player to shake
 * the screen by pressing e
 ************************************/

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("Select the object in the level to follow.")]
    public GameObject Target;
    [Tooltip("Set between 0 and 1, 0 is does not follow, and 1 is teleports to the target."), Range(0, 1)]
    public float interpolationVal = 0.5f;

    //Screen shake values
    float ShakeMagnitude = 0;
    float ShakeDuration = 0;
    float ShakeStartDuration = 0;

    public void StartShake(float magnitude, float duration)
    {
        if (magnitude > ShakeMagnitude)
            ShakeMagnitude = magnitude;
        if (duration > ShakeDuration)
        {
            ShakeDuration = duration;
            ShakeStartDuration = duration;
        }
    }

    //FixedUpdate is called once per physics frame
    private void FixedUpdate()
    {
        Vector3 newPos = transform.position;
        //make sure target exists
        if (Target != null)
        {
            newPos.x = Target.transform.position.x;
            newPos.y = Target.transform.position.y;
        }
        //transforming the position of the camera to the player
        transform.position = Vector3.Lerp(transform.position, newPos, interpolationVal);
        if (ShakeDuration > 0)
        {
            Vector3 randShake = Random.insideUnitCircle * (ShakeMagnitude * (ShakeDuration / ShakeStartDuration));
            transform.position += randShake;
            ShakeDuration -= Time.fixedDeltaTime;
        }
        else
        {
            ShakeMagnitude = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartShake(2, 2);
        }
    }
}
