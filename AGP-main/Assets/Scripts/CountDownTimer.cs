using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    // Start is called before the first frame update
   float currentTime=0f;
   float StartingTime=10f;

  [SerializeField] Text countdownText;
    void Start()
    {
        currentTime=StartingTime;

    }

    void update()
    {
        currentTime-= 1* Time.deltaTime;
        countdownText.text=currentTime.ToString("0");
        
        
        if(currentTime<=0){
            currentTime=0;
        }
    }

   
}
