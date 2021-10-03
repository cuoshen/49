using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBehavior : MonoBehaviour
{

    public GameObject activateTextMessage;

    // Start is called before the first frame update
    void Start()
    {
        activateTextMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Activate"))
        {
            activateTextMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Activate"))
        {
            activateTextMessage.SetActive(false);
        }
    }

}
