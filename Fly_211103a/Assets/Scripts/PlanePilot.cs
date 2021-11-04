using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour
{
    public float forwardSpeed = 25f, strafSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafSpeed, activeHoverSpeed, activeVRotationSpeed, activeHRotationSpeed;
    private float forwardAcceleration = 2.5f, strafAcceleration = 2f, hoverAcceleration = 2f;
    public float VRotation = 5f, HRotation = 5f;
    private float VRotationAcceleration = 2f, HRotationAcceleration = 2f;

    private void Start()
    {

    }
    void Update()
    {
        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Input.GetAxis("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafSpeed = Mathf.Lerp(activeStrafSpeed, Input.GetAxis("Horizontal") * strafSpeed, strafAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxis("Hover") * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);

        activeVRotationSpeed = Mathf.Lerp(activeVRotationSpeed, Input.GetAxis("VerticalRT") * VRotation, VRotationAcceleration * Time.deltaTime);
        activeHRotationSpeed = Mathf.Lerp(activeHRotationSpeed, Input.GetAxis("HorizontalRT") * HRotation, HRotationAcceleration * Time.deltaTime);

        transform.Rotate(-Vector3.right * activeVRotationSpeed * Time.deltaTime);
        transform.Rotate(-Vector3.forward * activeHRotationSpeed * Time.deltaTime);
    }
}
