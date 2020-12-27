using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float sidewaysForce = 50f;
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("i"))
        {
            rb.AddForce(0, 0, fowardForce * Time.deltaTime);
        }
        if (Input.GetKey("k"))
        {
            rb.AddForce(0, 0, -fowardForce * Time.deltaTime);
        }
        if (Input.GetKey("l"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("j"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("o"))
        {
            rb.AddForce(0, sidewaysForce * 15 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("[9]"))
        {
            transform.position = player.position + offset;
        }
        if (Input.GetKey("left shift"))
        {
            transform.position = player.position + new Vector3 (0,0,2);
        }
        if (Input.GetKeyUp("left shift"))
        {
            rb.AddForce(Random.Range(-10,10), -5, fowardForce * 5 * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
