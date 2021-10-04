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
        Vector2 displacement = direction * speed * Time.deltaTime;

        characterController.Move(new Vector3(displacement.x, 0.0f, displacement.y));
        characterAnimator.SetFloat("Speed", rawInput.magnitude);

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
