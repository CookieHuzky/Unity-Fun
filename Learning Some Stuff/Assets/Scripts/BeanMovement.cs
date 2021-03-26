using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanMovement : MonoBehaviour
{
    private CapsuleCollider c;
    private Rigidbody rb;
    public float jumpBoost;
    public float speed;
    //public float extraHeight;
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
        rb.velocity = new Vector3(1, 0, 0);
        Debug.Log(rb.velocity);
    }
    void Jump()
    {
        rb.velocity = Vector3.up * jumpBoost;
    }
    private bool IsGrounded()
    {
        /*bool rayHit = Physics.CapsuleCast(c.bounds.center, , c.radius, Vector3.down);
        Color rayColor;
        if (rayHit)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(c.bounds.center, Vector3.down * (c.bounds.extents.y + extraHeight), rayColor);
        return rayHit != false;
        */
        return true;
    }
}