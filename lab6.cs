using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab5 : MonoBehaviour
{
    private Animator anim;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;

    private enum MovementState { idle, running, jumping, falling}

    public LayerMask jumpableGround;
    private float dirX = 0f;
    public float moveSpeed = 7f;
    public float jumpForce = 14f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll =  GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        Move();
    }

    private void Move(){
        MovementState state;

        if(dirX > 0f ) 
        {
            state = MovementState.running;
            sprite.flipX = false;       
        }
        else if(dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state",(int)state);
    }

    private bool IsGrounded()
    {
        return  Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}

//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public Text cherriesText;
    private int cherries = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            Debug.Log("Cherrires: " + cherries);
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}
