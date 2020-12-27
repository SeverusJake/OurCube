
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Transform player2;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        if (Input.GetKey("1"))
        {
            transform.position = player.position + offset;
        }
        if (Input.GetKey("2"))
        {
            transform.position = player2.position + offset;
        }
    }
}
