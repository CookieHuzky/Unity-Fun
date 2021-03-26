using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanMovement : MonoBehaviour
{
    private CapsuleCollider c;
    private Rigidbody rb;
    private readonly float jumpBoost = 5;
    public float speed;
    private bool isSlow = false;
    private bool isGrounded;
    private bool isJump;
    void Start()
    {
        c = gameObject.GetComponent<CapsuleCollider>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (isSlow)
            {
                Time.timeScale = 1;
                isSlow = false;
            }
            else
            {
                Time.timeScale = 0.3f;
                isSlow = true;
            }
        }
        isGrounded = GroundCheck();
        isJump = Input.GetButton("Jump");
    }
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + move * Time.deltaTime * speed);

        if (isGrounded && isJump)
        {
            rb.velocity = Vector3.up * jumpBoost;
        }
    }
    private bool GroundCheck()
    {
        bool rayHit = (Physics.SphereCast(new Ray(c.bounds.center, Vector3.down), c.radius, c.bounds.extents.y - .4f));
        return (rayHit);
    }
}