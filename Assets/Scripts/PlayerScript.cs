using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   
    public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sideforce = 600f;



    void Start()
    {
        Debug.Log("Hellow");
        

    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime)  ;
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("d"))
        {

            rigidBody.AddForce( sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

    }
}
