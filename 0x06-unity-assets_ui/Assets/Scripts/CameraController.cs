using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform plyr;
    public bool isInverted;

    private const float turn_speed = 150f;
    private const float vert_speed = 150f;
    private Quaternion rotation;
    private Vector3 cameraRotation;
    private Vector3 _cameraOffset = new Vector3(0f, 2.5f, -6.25f);


    [Range(0.01f, 1.0f)]
    public float smootSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - plyr.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 itfollow = plyr.position + _cameraOffset;

        rotation = Quaternion.identity;
        if (isInverted == false)
            rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * vert_speed * Time.deltaTime, Vector3.right);
        else
            rotation = Quaternion.AngleAxis(-Input.GetAxis("Mouse Y")* vert_speed * Time.deltaTime, Vector3.right);

        _cameraOffset = rotation * _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, itfollow, smootSpeed);

        if (Input.GetKey(KeyCode.Mouse1))
            rotation = Quaternion.AngleAxis(-Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime, Vector3.up);
        else
            rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime, Vector3.up);

        _cameraOffset = rotation * _cameraOffset;
        transform.LookAt(plyr);
    }

    public void setCameraTarget(Transform p)
    {
        if (p != null)
            plyr = p;
        else
            Debug.LogError("Am I a joke to you? e.e");
    }
}
