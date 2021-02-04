using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float clock = 0;
    public Text TimerText;
    public bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!finish)
            clock += Time.deltaTime;

        float mins = Mathf.FloorToInt(clock / 60);
        float secs = (clock % 60);
        TimerText.text = string.Format("{0:00}:{1:00.00}", mins, secs);
        Debug.Log(TimerText);
    }
}
