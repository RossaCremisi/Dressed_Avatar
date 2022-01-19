using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private Touch touch;
    public Quaternion rotationX;
    public float rotateSpeedModifier = 0.1f;
    public float rot;
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {

                rotationX = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0);
                transform.rotation = rotationX * transform.rotation;
            }
        }
    }
}
