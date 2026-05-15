using System;
using Unity.VisualScripting;
using UnityEngine;

public class user : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("이동중2");
            Vector2 vec = new Vector2(1, 1);//1번이 x값 2번이 y값 추정
            transform.Translate(vec);
        }
    }

    void Start()
    {
       
    }
}