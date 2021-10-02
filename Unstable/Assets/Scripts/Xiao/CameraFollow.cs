using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 displacement;

    [SerializeField]
    private GameObject player;

    private void Update()
    {
        gameObject.transform.position = player.transform.position + displacement;
    }
}
