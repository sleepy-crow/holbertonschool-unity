using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject plyr;
    public Text timer;
    public GameObject win;
    public GameObject time;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            plyr.GetComponent<Timer>().finish = true;
            win.SetActive(true);
            time.SetActive(false);
        }
    }
}
