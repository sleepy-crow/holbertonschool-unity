using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float clock = 0;
    public Text TimerText;
    public bool finish = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moves = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        if (moves.magnitude >= 1 || clock != 0)
            if (!finish)
                clock += Time.deltaTime;

        float mins = Mathf.FloorToInt(clock / 60);
        float secs = (clock % 60);
        TimerText.text = string.Format("{0:00}:{1:00.00}", mins, secs);
    }
}
