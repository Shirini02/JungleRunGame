using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    Animator animator;
    public float jumpspeed;
    scoreincrement score;

    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        score = FindObjectOfType<scoreincrement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("hi");

            //playerRB.velocity = new Vector2(playerspeed*Time.deltaTime, 0);
            //playerRB.AddForce(Vector3.forward * playerspeed);
           
            animator.SetTrigger("Run");
            
            // playerRB.velocity = new Vector2(direction.x*playerspeed*Time.deltaTime, 0);
            // playerRB.AddForce(new ve)
           
            
            
        }
       
      
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                Jump();
                animator.SetTrigger("Jump");
                animator.SetTrigger("Run");
            }
            //playerRB.AddForce(Vector2.up * jumpspeed);
           // playerRB.velocity = new Vector2(0, jumpspeed);
            //animator.SetTrigger("Jump");
            //animator.SetTrigger("Idle");
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            print("Grounded");
            grounded = true;
        }
        if(collision.gameObject.tag=="Bird")
        {
            animator.SetTrigger("Dead");
            SceneManager.LoadScene(1);
            
        }
        if (collision.gameObject.tag == "Cactus")
        {
            animator.SetTrigger("Dead");
            SceneManager.LoadScene(1);
        }




    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Coin" )
        {
           collision.gameObject.SetActive(false);
            score.IncrementScore();
            


        }

        if (collision.gameObject.tag == "Crystal")
        {
            collision.gameObject.SetActive(false);
            score.CrustalIncScore();
        }
    }

    private  void Jump()
    {


        grounded = false;

        playerRB.velocity = new Vector2(0, jumpspeed);




    }
    
    
}
