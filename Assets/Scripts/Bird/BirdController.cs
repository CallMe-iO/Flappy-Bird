using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

    }
}
