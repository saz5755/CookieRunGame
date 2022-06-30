using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Button jumpButton;

    private bool isJump = false;
    private bool isTop = false;
    [SerializeField]
    private float jumpHeight = 2f;
    [SerializeField]
    private float jumpSpeed = 4f;

    Vector2 startPosition;

    private Rigidbody2D rigid;

    private void Awake()
    {
        //jumpButton.GetComponent<Button>();
        jumpButton.onClick.AddListener(PlayerJump);

        rigid = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        startPosition = transform.position;
    }
    private void Update()
    {




    }
    public void PlayerJump()
    {

        Debug.Log("¡°«¡ »£√‚ µ ");
        Debug.Log(transform.position.y);
        Debug.Log(startPosition.y);


        isJump = true;

        if (transform.position.y <= startPosition.y)
        {
            isJump = false;
            isTop = false;
            transform.position = startPosition;  
        }

        if (isJump) 
        {
            if (transform.position.y <= jumpHeight - .1f)
            {
                transform.position = Vector2.Lerp(transform.position,
                    new Vector2(transform.position.x, jumpHeight), jumpSpeed * Time.deltaTime);
            }
            else
            {
                isTop = true;
            }

            if (transform.position.y > startPosition.y && isTop)
            {
                transform.position = Vector2.MoveTowards(transform.position, startPosition, jumpSpeed * Time.deltaTime);
            }

            Debug.Log("¡°«¡ Ω««‡µ ");
        }
    }


}
