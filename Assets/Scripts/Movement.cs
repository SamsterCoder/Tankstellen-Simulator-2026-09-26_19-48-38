using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    private PlayerControlls playerControls;
    private Vector2 movement;
    private Rigidbody2D rigidbody;

    void Awake()
    {
        playerControls = new PlayerControlls();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        playerControls.Enable();
    }

    void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * speed * Time.fixedDeltaTime);
    }
}
