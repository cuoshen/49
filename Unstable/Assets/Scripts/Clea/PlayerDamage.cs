using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int maxTime = 100;
    public int currentTime;

    public TimeBar timeBar;

    void Start()
    {
        currentTime = maxTime;
        timeBar.SetMaxTime(maxTime);
    }

    void Start()
    {
        if (Input.GetKayDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentTime -= damage;
        timeBar.SetTime(currentTime);
    }
}
