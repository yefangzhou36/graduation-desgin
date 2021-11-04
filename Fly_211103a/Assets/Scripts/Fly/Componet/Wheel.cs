using UnityEngine;

public class Wheel : MonoBehaviour
{
    public Vector3 Axis = Vector3.one;

    // rotation along the Axis
    private void FixedUpdate()
    {
        this.transform.Rotate(Axis * Time.fixedDeltaTime);
    }
}