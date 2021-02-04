using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform plyr;
    public float turnSpeed = 0.40f;
    private Vector3 _cameraOffset;

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

        transform.position = Vector3.Slerp(transform.position, itfollow, smootSpeed);

    }
}
