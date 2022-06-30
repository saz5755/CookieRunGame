using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    Bounds bounds;
    private int jumpCount = 0;
    private int jumpmaxCount = 2;
    private bool isGround = false;
    private bool isJump = false;
    private bool isAnimPlay = false;
    
    private Animator anim;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        bounds = GetComponent<Collider2D>().bounds;
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = jumpmaxCount;
            isGround = true;
            if (isAnimPlay)
            {
                anim.SetBool("isJump", false);
            }
        }
    }
    private void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, bounds.extents.y + .1f, ~(1 << gameObject.layer));

        if (isGround)   //땅에 있을 때 점프 가능할건데
        {
            isJump = true;

            if (isJump)
            {
                if (jumpCount > 0)  // 2 , 1 ===> 2번 왜안돼
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        isAnimPlay = false;

                        Debug.Log("점프");
                         Vector2 velo = rigid.velocity;
                         velo.y = 5f;
                         rigid.velocity = velo;
                        jumpCount--;
                    }
                }
                else
                {
                    isJump = false;
                }

            }
        }
    }
}
