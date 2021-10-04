using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    private float rotationalSpeed = 30.0f;
    private Animator characterAnimator;
    private CharacterController characterController;
    [SerializeField]
    private float gravity = 9.8f;
    [SerializeField]
    private float verticalSpeed = 0.0f;
    [SerializeField]
    private bool isGrounded = true;
    [SerializeField]
    private GameObject mainCamera;

    int layerMask = 1 << 6;

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

        isGrounded = false;
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.green);
            if (hit.distance <= 0.5f)
            {
                isGrounded = true;
            }
        }

        verticalSpeed -= gravity * Time.deltaTime;
        if (isGrounded)
        {
            verticalSpeed = -gravity * Time.deltaTime;
        }

        characterAnimator.SetFloat("Speed", rawInput.magnitude);
        characterAnimator.SetFloat("VerticalSpeed", verticalSpeed);

        displacement.y = verticalSpeed * Time.deltaTime;

        characterController.Move(displacement);

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, new Vector3(direction.x, 0.0f, direction.y), rotationalSpeed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    public void upSpeed(float n)
    {
        speed += n;
    }

    public void deSpeed(float n)
    {
        speed -= n;
    }

    public void setSpeed(float n)
    {
        speed = n;
    }

    public float getSpeed()
    {
        return speed;
    }
}
