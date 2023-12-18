using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commands : MonoBehaviour
{
    public float force = 10f;

    public void jump() {
        GetComponent<Rigidbody>().AddForce(
            Vector3.up * force, ForceMode.Impulse);
    }
    public void moveForward() {
        GetComponent<Rigidbody>().AddForce(
            transform.forward * force, ForceMode.Impulse);
    }
}
