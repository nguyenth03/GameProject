using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3 : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;

    private float dirX = 0f;
    public float moveSpeed = 7f;
    public float jumpForce = 14f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        Move();
    }

    private void Move(){
        if(dirX > 0f ) 
        {
            anim.SetBool("running",true);
            sprite.flipX = false;       
        }
        else if(dirX < 0f)
        {
            anim.SetBool("running",true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running",false);
        }
    }

}

//////drag CamareMain
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update()
    {
        transform.position = new Vector3(player.position.x,player.position.y,transform.position.z);
    }
}

