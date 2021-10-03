using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    private float rotationalSpeed = 30.0f;
    private Animator characterAnimator;
    private CharacterController characterController;
    [SerializeField]
    private float gravity = 9.8f;
    [SerializeField]
    private float verticalSpeed = 0.0f;

    private void Awake()
    {
        characterAnimator = gameObject.GetComponent<Animator>();
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rawInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 direction = rawInput.normalized;
        Vector2 displacementXY = direction * speed * Time.deltaTime;
        Vector3 displacement = new Vector3();
        displacement.x = displacementXY.x; displacement.z = displacementXY.y;

        verticalSpeed -= gravity * Time.deltaTime;
        if (characterController.isGrounded)
        {
            verticalSpeed = 0.0f;
        }

        characterAnimator.SetFloat("Speed", rawInput.magnitude);
        characterAnimator.SetFloat("VerticalSpeed", verticalSpeed);

        displacement.y = verticalSpeed * Time.deltaTime;

        characterController.Move(displacement);

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, new Vector3(direction.x, 0.0f, direction.y), rotationalSpeed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
