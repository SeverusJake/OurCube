using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float sidewaysForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, fowardForce * Time.deltaTime );
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, - fowardForce * Time.deltaTime );
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y <= 1.01)
        { 
            if (Input.GetKey("c") || Input.GetKey("[5]"))
            {
                rb.AddForce(0,sidewaysForce * 15 * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
