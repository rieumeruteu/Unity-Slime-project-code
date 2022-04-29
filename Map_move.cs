using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_move : MonoBehaviour
{
    SpriteRenderer temp;
    public SpriteRenderer[] tiles; //ground ������Ʈ���� ��� �迭
    public Sprite[] groundimg;
    public float speed;


    private void Start()
    {
        temp = tiles[0];
    }

    private void Update()
    {
        for(int i=0; i<tiles.Length;i++)
        {
            if(3>=tiles[i].transform.position.x)//Ÿ���� x��ǥ�� 3���� ������ 
            {
                for(int x=0; x<tiles.Length;x++)
                {
                    if (temp.transform.position.x < tiles[x].transform.position.x)//�� ������ Ÿ��(�� �ڿ� �ִ� Ÿ��) ��ġ�� �޴´�.
                        temp = tiles[x];// temp�� ��ǥ (x:24,y:0,z:0)
                }
                tiles[i].transform.position = new Vector2(temp.transform.position.x + 3,-1.22f);//Ÿ�� ���Ӱ� ��ġ, �� ũ�Ⱑ 3�̶� x+3�� �ߴ�. y�� ���� �����Ǿ����� 1.22 ��ŭ ���̳���
                //tiles[i].sprite = groundimg[Random.Range(0, groundimg.Length)]; //Ÿ���� �ϳ��� �ּ�ó�� ���࿡ �������� Ÿ���̸� �����ϰ� ���� ����

            }
        }


        for(int i=0; i<tiles.Length;i++)
        {
            tiles[i].transform.Translate(new Vector2(-3, 0) * Time.deltaTime*speed);//Ÿ�ϵ��� �������� �̵�
            
        }
    }
}
