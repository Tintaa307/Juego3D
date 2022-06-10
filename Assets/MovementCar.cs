using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCar : MonoBehaviour
{
    bool isRight = true;
    public float moveCar = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -12)
        {
            isRight = true;
        }
        else if (transform.position.z >= 12)
        {
            isRight = false;
        }

        if (isRight)
        {
            transform.Translate(0, 0, moveCar);
        }

        if (!isRight)
        {
            transform.Translate(0, 0, -moveCar);
        }
    }
}
