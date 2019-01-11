using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
//on collision with lemon it will and 1 point and destroys the lemon
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lemon")
        {
            UITextUpdate.score += 1;
           
            Destroy(collision.gameObject);
        }

    }
  
//when touching 3rd beam it takes us to the "game over" scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Ouch")
        {
            SceneManager.LoadScene(2);
        }
    }
}


