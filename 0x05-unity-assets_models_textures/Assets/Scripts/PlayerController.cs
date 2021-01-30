using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb_player;
    public float speed = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        rb_player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move Up
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb_player.AddForce(0, 0, speed * Time.deltaTime);
        }
        // Move Down
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb_player.AddForce(0, 0, -speed * Time.deltaTime);
        }
        // Move Left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb_player.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        // Move Right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb_player.AddForce(speed * Time.deltaTime, 0, 0);
        }
        // jump
        if (Input.GetKey("space"))
        {
            rb_player.AddForce(0, speed * Time.deltaTime, 0);
        }
    }
}
