using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject plyr;
    public Text timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"));
        {
            plyr.GetComponent<Timer>().finish = true;
            timer.color = Color.green;
            timer.fontSize = 56;
        }
    }
}
