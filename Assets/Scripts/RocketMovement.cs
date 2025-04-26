using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustStrength = 100f;
    Rigidbody rb;

    private void OnEnable()
    {
        thrust.Enable();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (thrust.IsPressed())
        {
           rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
        }
    }
}
