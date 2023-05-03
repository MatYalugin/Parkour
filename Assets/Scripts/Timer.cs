using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Time = 20;
    float Counter;
    bool timerTick = true;
    public Animator lavaAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        if (timerTick == true)
        {
            Counter += 0.02f;
            if (Counter >= Time)
            {
                Debug.Log("Timer Expires");
                timerTick = false;
                lavaAnimator.Play("LavaUp");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
