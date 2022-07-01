using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform handleGrabTarget;
    public Rigidbody doorHandleFixedJoint_Rb;

    private void FixedUpdate()
    {
        doorHandleFixedJoint_Rb.MovePosition(handleGrabTarget.position);
    }

    private void Start()
    {
        releaseHandle();
    }
    public void releaseHandle()
    {
        handleGrabTarget.position = transform.position;
        handleGrabTarget.rotation = transform.rotation;
        doorHandleFixedJoint_Rb.velocity = Vector3.zero;
        doorHandleFixedJoint_Rb.angularVelocity = Vector3.zero;
    }
}
