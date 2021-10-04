using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 displacement;
    [SerializeField]
    private Vector3 eulerViewAngle;
    [SerializeField]
    private int phase = 0;
    [SerializeField]
    private float cameraSpeed = 10.0f;

    [SerializeField]
    private GameObject player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            phase++;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            phase--;
        }
        Vector3 finalDisplacement = Quaternion.EulerAngles(0, phase * 90.0f, 0) * displacement;
        // Direct update
        //gameObject.transform.position = player.transform.position + finalDisplacement;
        Vector3 newPosition = player.transform.position + finalDisplacement;
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, newPosition, cameraSpeed);
        gameObject.transform.LookAt(player.transform, Vector3.up);
    }
}
