using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_move : MonoBehaviour
{
    SpriteRenderer temp;
    public SpriteRenderer[] tiles; //ground 오브젝트들을 담는 배열
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
            if(3>=tiles[i].transform.position.x)//타일의 x좌표가 3보다 작으면 
            {
                for(int x=0; x<tiles.Length;x++)
                {
                    if (temp.transform.position.x < tiles[x].transform.position.x)//맨 마지막 타일(맨 뒤에 있는 타일) 위치를 받는다.
                        temp = tiles[x];// temp의 좌표 (x:24,y:0,z:0)
                }
                tiles[i].transform.position = new Vector2(temp.transform.position.x + 3,-1.22f);//타일 새롭게 배치, 블럭 크기가 3이라서 x+3을 했다. y는 새로 생성되었을떄 1.22 만큼 차이났음
                //tiles[i].sprite = groundimg[Random.Range(0, groundimg.Length)]; //타일이 하나라서 주석처리 만약에 여러개의 타일이면 랜덤하게 생성 가능

            }
        }


        for(int i=0; i<tiles.Length;i++)
        {
            tiles[i].transform.Translate(new Vector2(-3, 0) * Time.deltaTime*speed);//타일들을 좌측으로 이동
            
        }
    }
}
