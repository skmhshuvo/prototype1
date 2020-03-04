using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verInput;
    public float horInput;
    public float moveSpeed = 30;
    public float steerAngle = 10;

    // Update is called once per frame
    void Update()
    {
        verInput = Input.GetAxis("Vertical");
        horInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * verInput * moveSpeed);
        transform.Rotate(Vector3.up * horInput * steerAngle);
    }
}
