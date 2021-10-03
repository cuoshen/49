using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot_Light : MonoBehaviour
{
    public bool player_casted = false;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speed;

    private Vector3 startingPosition;
    private double phase = 0.0;

    private void Start()
    {
        startingPosition = gameObject.transform.position;
    }

    private void Move()
    {
        phase += Time.deltaTime;
        Debug.Log(phase);
        Vector3 newPosition = startingPosition;
        gameObject.transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

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
