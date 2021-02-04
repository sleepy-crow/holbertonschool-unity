using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
    private Rigidbody plyr;
    public float speedForce = 5.0f;
    private float jumpHeight = 2.0f;
    private float gravityValue = -15.81f;

    // Start is called before the first frame update
    void Start()
    {
        plyr = GetComponent<Rigidbody>();
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        Vector3 moves = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(moves * Time.deltaTime * speedForce);

        if (Input.GetKeyDown(KeyCode.Space) && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (transform.position.y <= -25.5)
        {
            transform.position = new Vector3(0, 20, 0);
        }
    }
}
