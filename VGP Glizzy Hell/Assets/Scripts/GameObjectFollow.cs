using UnityEngine;

public class GameObjectFollow : MonoBehaviour
{
    [Tooltip("Select the object in the level to follow.")]
    public GameObject Target;
    [Tooltip("Set between 0 and 1, 0 is does not follow, and 1 is teleports to the target."), Range(0, 1)]
    public float interpolationVal = 0.5f;

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
        transform.position = Vector3.Lerp(transform.position, newPos, interpolationVal);
    }
}
