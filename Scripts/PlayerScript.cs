using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    public float thrust = 100.0f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(transform.forward * thrust);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb.AddForce(-transform.forward * thrust);
        }
        if (Input.GetKey(KeyCode.A)) {
            rb.AddForce(-transform.right * thrust);
        }
        if (Input.GetKey(KeyCode.D)) {
            rb.AddForce(transform.right * thrust);
        }
        /*if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * thrust);
        }*/
        if (Input.GetKey(KeyCode.Space)){
            transform.position = new Vector3(transform.position.x, transform.position.y + thrust * Time.deltaTime, transform.position.z);
        }
    }
}