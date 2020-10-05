using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private float rotationFactor = 8f;
    private float xRotation = 0;
    private float zRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left") && zRotation < 10)
        {
            zRotation += rotationFactor;
            TiltLeftAndRight(zRotation);
        }
        if(Input.GetKey("right") && zRotation > -10)
        {
            zRotation -= rotationFactor;
            TiltLeftAndRight(zRotation);
        }
        if(Input.GetKey("up") && xRotation < 10)
        {
            xRotation += rotationFactor;
            TiltUpAndDown(xRotation);
        }
        if(Input.GetKey("down") && xRotation > -10)
        {
            xRotation -= rotationFactor;
            TiltUpAndDown(xRotation);
        }
    }

    void TiltLeftAndRight(float zRot){
        
        gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, zRot);
    }

    void TiltUpAndDown(float xRot){
        gameObject.transform.Rotate(xRot, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z);
    }

}
