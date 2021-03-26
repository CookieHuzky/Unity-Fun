using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanMovement : MonoBehaviour
{
    private CapsuleCollider c;
    private Rigidbody rb;
    void Start()
    {
        c = gameObject.GetComponent<CapsuleCollider>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity = Vector3.up * 10;
    }
    private bool IsGrounded()
    {
        float extraHeight = .01f;
        bool rayHit = Physics.Raycast(c.bounds.center, Vector3.down, c.bounds.extents.y + extraHeight);
        Color rayColor;
        if (rayHit)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(c.bounds.center, Vector3.down * (c.bounds.extents.y + extraHeight));
        return rayHit != false;
    }
}
