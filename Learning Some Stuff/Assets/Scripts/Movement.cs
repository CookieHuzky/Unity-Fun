using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float hor;
    float ver;
    float jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = -Input.GetAxis("Horizontal");
        ver = -Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");
    }
    private void FixedUpdate()
    {
        Vector3 pos = rb.position;

        pos.x = pos.x + speed * hor * Time.deltaTime;
        pos.z = pos.z + speed * ver * Time.deltaTime;
        pos.y = pos.y + speed * jump * Time.deltaTime;

        rb.MovePosition(pos);
    }
}
