using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mosterGenerate : MonoBehaviour
{
    public GameObject Mob;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;

    public float SpeedMultiplier;
    
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateMonster();
    }

    public void GenerateSequence()//���� ���� 
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateMonster", randomWait);
    }



     void generateMonster()
    {
        GameObject obstacle = Instantiate(Mob, transform.position, transform.rotation);

        obstacle.GetComponent<monster>().Monster = this;
    }

   
    void Update()
    {
        if(CurrentSpeed<MaxSpeed)
        {
            CurrentSpeed += SpeedMultiplier;//�ӵ��� ������ ������ ä�� ��ֹ� ����
        }
    }
}
