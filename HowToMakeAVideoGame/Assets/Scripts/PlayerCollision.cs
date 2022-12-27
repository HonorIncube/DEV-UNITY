using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //Si collisionInfo rencontre obstacle alors retirer la capacité de bouger au joueur
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
