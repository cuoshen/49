using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private Timer timer;
    public AudioSource SlowHeartbeat;
    public AudioSource MediumHeartbeat;
    public AudioSource FastHeartbeat;
    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.time <= 60 && timer.time > 40)  //these values are arbitrary. we will reassign them once we decide how long we want our timer to be.
        {
            if(!SlowHeartbeat.isPlaying && !MediumHeartbeat.isPlaying && !FastHeartbeat.isPlaying)
            {
                SlowHeartbeat.Play();
            }
        }
        if (timer.time <= 40 && timer.time > 20)
        {
            if (!SlowHeartbeat.isPlaying && !MediumHeartbeat.isPlaying && !FastHeartbeat.isPlaying)
            {
                MediumHeartbeat.Play();
            }
        }
        if (timer.time <= 20 && timer.time > 0)
        {
            if (!SlowHeartbeat.isPlaying && !MediumHeartbeat.isPlaying && !FastHeartbeat.isPlaying)
            {
                FastHeartbeat.Play();
            }
        }

    }
}
