using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;

    public float speed;
    public float restartTimer;
    public int health;
    private int startHealth = 3;

    private bool facingRight; 

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = startHealth;
        facingRight = true;
        Debug.Log("pínis");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity = movement.normalized * speed;

        float dir = Mathf.Sign(moveVelocity.x);
        Flip(dir);
        
      /*  if(health <= 0 && !GameManager.instance.gameOver)
        {
            
            GameManager.instance.gameOver = true;
            if (GameManager.instance.gameOver)
            {
                SceneManager.LoadScene(0);
                GameManager.instance.gameOver = false;
                health = startHealth;
            }
            
       } */
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
           // ScoreManager.instance.score += 1;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Beam")
        {
            health -= 1;
            Debug.Log(health);
        }
    }

    void Flip(float dir)
    {

        if (dir > 0 && !facingRight || dir < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector2 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }
}
