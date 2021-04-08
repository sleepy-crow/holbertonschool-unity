using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Transform cam;
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
    public float speedForce = 5.0f;
    private float jumpHeight = 2.0f;
    private float gravityValue = -15.81f;
    public bool canMove = true;
    public float rotationsmoot = 0.7f;
    float smootrotation;
    public GameObject ty;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {

                playerVelocity.y = 0f;
            }
            // this where the movements of the player are handled
            Vector3 moves = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            // here starts the part to make forward on when the camera is looking to
            if (moves.magnitude >= 0.1f)
            {

                float theAngle = Mathf.Atan2(moves.x, moves.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float Smoot = Mathf.SmoothDampAngle(transform.eulerAngles.y, theAngle, ref smootrotation, rotationsmoot);
                transform.rotation = Quaternion.Euler(0f, Smoot, 0f);

                Vector3 dir = Quaternion.Euler(0f, theAngle, 0f) * Vector3.forward;
                
                controller.Move(dir * Time.deltaTime * speedForce);
            }
            if (moves.magnitude != 0f)
            {
                ty.GetComponent<Animator>().SetBool("isRunning", true);
            }
            else
            {
                ty.GetComponent<Animator>().SetBool("isRunning", false);
            }
            // here ends

            // here is hadled the jump of the player
            if (Input.GetKeyDown(KeyCode.Space) && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }
            // gravity applied to the player
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
            // limmit of fall and reposition of the player
            if (transform.position.y <= -25.5)
            {
                transform.position = new Vector3(0, 20, 0);
            }
        }
        else
        {
            transform.position = new Vector3(9, 3, 93);
            canMove = true;
        }
    }
}
