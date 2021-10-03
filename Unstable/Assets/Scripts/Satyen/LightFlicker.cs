using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightCycle());
    }


    IEnumerator LightCycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            gameObject.SetActive(true);
            Debug.Log("1");
            yield return new WaitForSeconds(1);
            gameObject.SetActive(false);
            Debug.Log("2");
            Debug.Log("3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
