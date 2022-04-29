using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    [SerializeField]
    float speed = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(new Vector2(-3, 0) * Time.deltaTime * speed);
    }
}
