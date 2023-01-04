using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 250f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Je go a gauche
        if (Input.GetKey("d"))
        {
            // RigidBody.ajouter de la force (sidewayForce * Time.deltaTime, position y, position z, avec modificateur ForceMode.VelocityChange)
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Je go a droite
        if (Input.GetKey("q")) 
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Si position "y" du Rigidbody est inférieur à -1 alors appeller l'objet "GameManadger" et plus précisement "EndGame"
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
