using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot_Light : MonoBehaviour
{
    public bool player_casted = false;

    [SerializeField]
    private GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3 Light2Player = (player.transform.position - transform.position).normalized;

        Ray ray = new Ray(transform.position, Light2Player);
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
