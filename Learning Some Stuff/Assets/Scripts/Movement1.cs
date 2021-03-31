using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public CharacterController c;
    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 d = new Vector3(h, 0f, v).normalized;

        if (d.magnitude >= 0.1f)
        {
            c.Move(d * speed * Time.deltaTime);
        }
    }
}
