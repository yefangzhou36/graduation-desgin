using UnityEngine;

[RequireComponent(typeof(FlightSystem))]
public class PlayerController : MonoBehaviour
{
    FlightSystem flight;// Core plane system
    FlightView View;
    public bool Active = true;
    public bool SimpleControl;// make it easy to control Plane will turning easier.
    private bool directVelBack;
    public GUISkin skin;
    public bool ShowHowto;

    void Start()
    {
        flight = this.GetComponent<FlightSystem>();
        View = (FlightView)GameObject.FindObjectOfType(typeof(FlightView));

        if (flight)
            directVelBack = flight.DirectVelocity;
    }

    void Update()
    {
        if (!flight || !Active)
            return;

        // Desktop controller
        flight.SimpleControl = SimpleControl;

        // lock mouse position to the center.
        MouseLock.MouseLocked = true;

        flight.AxisControl(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
        if (SimpleControl)
        {
            flight.DirectVelocity = false;
            flight.TurnControl(Input.GetAxis("Mouse X"));
        }
        else
        {
            flight.DirectVelocity = directVelBack;
        }

        flight.TurnControl(Input.GetAxis("Horizontal"));
        flight.SpeedUp(Input.GetAxis("Vertical"));


        if (Input.GetButton("Fire1"))
        {
            flight.WeaponControl.LaunchWeapon();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            flight.WeaponControl.SwitchWeapon();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (View)
                View.SwitchCameras();
        }
    }
}
