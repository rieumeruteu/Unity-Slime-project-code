using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public mosterGenerate Monster;
    
    void Update()
    {
        transform.Translate(Vector2.left * Monster.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("next Line"))
        {
            Monster.GenerateSequence();
        }

        if(collision.gameObject.CompareTag("end"))
        {
            Destroy(this.gameObject);
        }
    }
}
