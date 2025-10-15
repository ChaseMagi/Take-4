using UnityEngine;

public class Movemnt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody myRb;

    void Start()
    {
        myRb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) 
        {
            myRb.AddForce(0f, 0f, 1f);
        }
        if (Input.GetKey("s")) 
        {
            myRb.AddForce(0f, 0f, -1f);
        }
        if (Input.GetKey("a")) 
        {
            myRb.AddForce(-1f, 0f, 0f);
        }
        if (Input.GetKey("d")) 
        {
            myRb.AddForce(1f, 0f, 0f);
        }
        if(Input.GetKey("q"))
        {
            myRb.AddForce(0f, 1f, 0f);
        }
        if (Input.GetKey("e")) 
        {
            myRb.AddForce(0f, -1f, 0f);
        }
    }
}
