using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    bool Jump = false;
    bool Top = false;
    [SerializeField]
    float jumpHeight = 0;
    [SerializeField]
    float jumpSpeed = 0;

    Vector2 startPosition;
    Animator animator;

    private void Start()
    {
        startPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool("Move", true);

        if(Input.GetMouseButtonDown(0))
        {
            Jump = true;
        }
        else if(transform.position.y<=startPosition.y)
        {
            Jump = false;
            Top = false;
            transform.position = startPosition;
        }

        if(Jump)
        {
            if(transform.position.y<=jumpHeight-0.1f&&!Top)
            {
                transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x, jumpHeight), jumpSpeed * Time.deltaTime);
            }
            else
            {
                Top = true;
            }
            if(transform.position.y> startPosition.y&&Top)
            {
                transform.position = Vector2.MoveTowards(transform.position, startPosition, jumpSpeed * Time.deltaTime);
            }
        }
    }
}
