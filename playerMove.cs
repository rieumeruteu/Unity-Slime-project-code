using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    public float JumpPower;
    float distanceScore;//거리 점수

    public Text ScoreTxt;// 점수텍스트

    [SerializeField]
    bool isGround = false;
    bool isAlive = true;//생존

    Rigidbody2D RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        distanceScore = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGround==true)
            {
                RB.AddForce(Vector2.up * JumpPower);
                isGround = false;

            }
        }

        if(isAlive)
        {
            distanceScore += Time.deltaTime * 4;
            ScoreTxt.text = "점수: " + distanceScore.ToString();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGround==false)
            {
                isGround = true;
            }
        }

        if (collision.gameObject.CompareTag("Monster"))
        {
            isAlive = false;
            Time.timeScale = 0;// 죽으면 일시정지 
        }
    }
}
