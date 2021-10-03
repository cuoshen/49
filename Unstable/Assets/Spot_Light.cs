using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot_Light : MonoBehaviour
{
    public bool player_casted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, GameObject.Find("Test Character").transform.position - transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Player"))
                player_casted = true;
            else
                player_casted = false;
        }
    }
}
