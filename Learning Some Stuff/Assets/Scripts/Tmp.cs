using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tmp : MonoBehaviour
{
    private CapsuleCollider c;
    void Start()
    {
        c = gameObject.GetComponent<CapsuleCollider>();
        Debug.Log(c.bounds);
    }
}
