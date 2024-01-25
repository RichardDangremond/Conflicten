using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventphone : MonoBehaviour


{
    [SerializeField] private GameObject audioManager;
    [SerializeField] private int beltoon1Time = 420;
    [SerializeField] private int beltoon2Time = 300;

    private int currentTime = 0;
    private int startTime = 450;
    


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        Invoke("Timeraftellen", 1);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    private void Timeraftellen() 
    {
        currentTime -= 1;
        if (currentTime >= 0)
        {
            Invoke("Timeraftellen", 1);
            Debug.Log(currentTime);

           
        }

        if (currentTime == beltoon1Time)
        {
            Belgeluid1(); Debug.Log("2afspelen");
        }


    }

    private void Belgeluid1()
    {
        Debug.Log("afspelen");
        audioManager.GetComponent<AudioManager>().PlayLongSound("AlarmClock");

    }
        
    
}
