using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class user : MonoBehaviour
{
    void Update()
    { 
        Input.GetKeyDown(KeyCode.D);
        {
            Debug.Log("이동중");
            Vector2 vec = new Vector2(1, 1);//1번이 x값 2번이 y값 추정
            transform.Translate(vec);
        }
    }
    void Start()
    {
       
    }
}