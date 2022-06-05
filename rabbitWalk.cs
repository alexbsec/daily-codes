using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitWalk : MonoBehaviour
{

    public float speed = .5f;
    public float jumpForce = 100f;

    private bool isAllowedToJump;


    private Rigidbody2D rb;
    private Animator animator;


    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    public void Update()
    {
        isAllowedToJump = false;
        animator.SetBool("jump", isAllowedToJump);

        if ( Input.GetKeyDown(KeyCode.Z) )
        {
            isAllowedToJump = true;
            Vector2 force = new Vector2(0, 1);
            animator.SetBool("jump", isAllowedToJump);
            rb.AddForce(force * jumpForce);
        }



    }



    public void FixedUpdate()
    {
        Vector3 currentPosition = gameObject.transform.position;
        float key = Input.GetAxisRaw("Horizontal");
        Vector3 moveTo;

        switch ( key )
        {
            case 0:
                animator.SetBool("moving", false);
                break;

            case 1:
                moveTo = new Vector3(key, 0);
                animator.SetBool("moving", true);
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                gameObject.transform.Translate(moveTo * Time.deltaTime * speed);
                break;

            case -1:


                moveTo = new Vector3(key, 0);
                animator.SetBool("moving", true);
                gameObject.transform.localScale = new Vector3(-1, 1, 1);
                gameObject.transform.Translate(moveTo * Time.deltaTime * speed);

                break;



        }

    }
}
