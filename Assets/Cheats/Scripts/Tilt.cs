using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private float rotationFactor = 0.1f;
    private float xRotation = 0;
    private float zRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Right
        if(Input.GetAxis("Horizontal") > 0.1 && (gameObject.transform.rotation.z > -0.20))
        {
            print(gameObject.transform.rotation.z);
            TiltLeftAndRight(-rotationFactor);
        }
        //Left
        if(Input.GetAxis("Horizontal") < -0.1 && (gameObject.transform.rotation.z < 0.20))
        {
            TiltLeftAndRight(rotationFactor);
        }
        //Up
        if(Input.GetAxis("Vertical") > 0.1 && (gameObject.transform.rotation.x < 0.20))
        {
            TiltUpAndDown(rotationFactor);
        }
        //Down
        if(Input.GetAxis("Vertical") < -0.1 && (gameObject.transform.rotation.x > -0.20))
        {
            TiltUpAndDown(-rotationFactor);
        }
    }

    void TiltLeftAndRight(float factor){
        
        transform.Rotate(0, 0, factor);
    }

    void TiltUpAndDown(float factor){
        gameObject.transform.Rotate(factor, 0, 0);
    }

}
