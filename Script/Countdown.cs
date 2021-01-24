using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float Timer;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        int Timerint = (int)Timer;
        TimerText.text = Timerint.ToString();
        if(Timer <= 0f)
        {
            //Zeit abgelaufen
        }
    }
}
