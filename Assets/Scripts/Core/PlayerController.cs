using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1f;
    [SerializeField]
    private float RotateSpeed = 1f;

    private Rigidbody rb;
    private Vector3 MoveDirection;
    private float horizontal;

    private readonly float gravity = -50;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveDirection = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        horizontal = Input.GetAxisRaw("Horizontal") * RotateSpeed;
        //if(Input.GetButtonDown("Jump"))
        //{
        //    Instantiate(Resources.Load("Prefabs/Eat"), Random.onUnitSphere * 15f, Quaternion.identity);
        //}

    }

    private void FixedUpdate()
    {
        Vector3 gravityUp = (transform.position - Vector3.zero).normalized;

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, gravityUp) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50f * Time.deltaTime);
        transform.rotation = transform.rotation * Quaternion.AngleAxis(horizontal, Vector3.up);

        rb.AddForce(gravityUp * gravity);
        rb.MovePosition(rb.position + transform.TransformDirection(MoveDirection.normalized) * Speed / 10f);
    }
}
