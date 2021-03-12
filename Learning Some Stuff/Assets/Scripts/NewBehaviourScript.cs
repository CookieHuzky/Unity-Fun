using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int frames = 0;
    void Start()
    {
        while (Input.GetKeyDown(KeyCode.E))
        {
            frames++;
            Debug.Log("E " + frames + " Frames lang gedrückt");
        }
    }
}
