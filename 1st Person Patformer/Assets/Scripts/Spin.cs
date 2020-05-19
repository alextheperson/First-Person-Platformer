using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    

    public float RotationPerSecond = 0.25f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, RotationPerSecond);
    }
}
