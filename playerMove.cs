using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    public float JumpPower;
    float distanceScore;//�Ÿ� ����

    public Text ScoreTxt;// �����ؽ�Ʈ

    [SerializeField]
    bool isGround = false;
    bool isAlive = true;//����

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
            ScoreTxt.text = "����: " + distanceScore.ToString();
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
            Time.timeScale = 0;// ������ �Ͻ����� 
        }
    }
}
