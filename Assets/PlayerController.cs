using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float xSpeed;
    float rotateSpeed;

    // Use this for initialization
    void Start() {
        xSpeed = 0.9f;
        rotateSpeed = 4;
    }

    // Update is called once per frame
    void Update() {

        // Movimiento

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(-xSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -90, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 90, 0);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Auto" || col.gameObject.name == "AutoInv")
        {
            transform.position = new Vector3(72.71f, 0.5f, -0.02f);
        }
    }
}
