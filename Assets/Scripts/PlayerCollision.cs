using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle");
            FindObjectOfType<GameManager>().EndGame();
            movement.enabled = false;
        }
      
    }
}
