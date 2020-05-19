using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float leftTurnSpeed = 45.0f;
    public float rightTurnSpeed = 45.0f;
    public float upTurnSpeed = 45.0f;
    public float downTurnSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Time.deltaTime * (-leftTurnSpeed), 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, Time.deltaTime * rightTurnSpeed, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Time.deltaTime * (-upTurnSpeed), 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Time.deltaTime * downTurnSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
