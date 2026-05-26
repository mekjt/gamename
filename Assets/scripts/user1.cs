using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdf : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] float speed = 3.0f;
    [SerializeField] float upspeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpDir = new Vector2(0, jumpForce);
            rb.AddForce(jumpDir, ForceMode2D.Impulse);
        }
            Movement();
    }

    void Movement()
    {
        float h = Input.GetAxis("Horizontal");//가로가 맞는데?????  x값이고
        float v = Input.GetAxis("Vertical");//세로고 
        float x = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            x = speed * upspeed;
        }
        rb.linearVelocity = new Vector2(h * x, rb.linearVelocity.y);
        Vector2 velocity = new Vector2(h, v).normalized;
        //rb.velocity = velocity * speed;
        // Movement() 내부 수정 예시 (X축만 입력 적용, Y축은 물리 엔진에 위임)
        //rb.linearVelocity = new Vector2(h * speed, rb.linearVelocity.y);
        // rb.velocity = new Vector2(h * speed, -upspeed);
    }
}