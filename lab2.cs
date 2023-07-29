using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab2 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,9,0);
        }
    }
}
