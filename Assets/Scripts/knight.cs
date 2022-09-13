using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rigid;
    private Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            rigid.velocity = Vector2.right * speed;

        if (Input.GetKey(KeyCode.UpArrow))
            rigid.velocity = Vector2.up * speed;

        if (Input.GetKey(KeyCode.LeftArrow))
            rigid.velocity = Vector2.left * speed;

        if (Input.GetKey(KeyCode.DownArrow))
            rigid.velocity = Vector2.down * speed;

        if (Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = Vector2.zero;
            anim.SetBool("standingstill", true);
        }
    }
}

