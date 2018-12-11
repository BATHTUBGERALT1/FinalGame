using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {


    // this deletes the sugar on collision with the player

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // checks if the player actually collided with us 
        Player playerScript = collision.collider.GetComponent<Player>();

        // if we have touched something that has the player script
        // it is the player so we die
        
        if (playerScript != null)
        {

        }
    }
}

