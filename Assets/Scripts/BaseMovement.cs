using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BaseMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;

    [Header("References")]
    [SerializeField]
    private Rigidbody myRigidBody;



    // Start is called before the first frame update
    void Awake()
    {
        if(!myRigidBody) 
        {
            myRigidBody = GetComponent<Rigidbody>();
        }
    }

    public void Move(Vector3 moveDirection)
    {
        myRigidBody.velocity = moveDirection.normalized * moveSpeed;
    }
}
