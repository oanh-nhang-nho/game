using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*    float horizontalSpeed = 0.2f;
        float verticalSpeed = 0.2f;

        void Update()
        {
            // Get the mouse delta. This is not in the range -1...1
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");

            transform.Translate(h, v, 0);
        }*/
    // Update is called once per frame
    public float speed = 10.0f;
    //public float rotationSpeed = 100.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(rotation, translation, 0);

        // Rotate around our y-axis
        //transform.Rotate(0, rotation, 0);
    }
}
