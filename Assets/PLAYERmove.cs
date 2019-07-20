using UnityEngine;

public class PLAYERmove : MonoBehaviour
{ // This is the refrence to Rigitbody component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForse = 500f;

    // We marked this as "fixed" Update because we are using it to mess with physycs
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForse * Time.deltaTime, 0, 0);
 
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForse * Time.deltaTime, 0, 0);


        }
    }
}
