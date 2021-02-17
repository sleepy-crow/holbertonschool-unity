using UnityEngine;

public class Portal : MonoBehaviour
{
    public PlayerController plyr;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            plyr.canMove = false;
        }
    }
}
