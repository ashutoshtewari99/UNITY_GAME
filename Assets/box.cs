using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{ 

    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,2,2000 * Time.deltaTime);
    }
}
