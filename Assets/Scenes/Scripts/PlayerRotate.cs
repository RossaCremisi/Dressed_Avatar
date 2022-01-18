using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationY;

    private float rotateSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {

                rotationY = Quaternion.Euler(0f,- touchPosition.x * rotateSpeed, 0f);
                transform.rotation = rotationY* transform.rotation;
                Debug.Log("Entrato");
            }
        }
    }
}
