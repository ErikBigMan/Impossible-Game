using UnityEngine;

public class PlayerMovment : MonoBehaviour{

    public Rigidbody rb;

    public float ForwardForce = 8f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(ForwardForce * Time.deltaTime, 0, 0);
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 1000 * Time.deltaTime, 0);
        }
    }
}
