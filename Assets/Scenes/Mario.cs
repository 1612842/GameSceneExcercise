using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public GameObject test;
    Vector2 pos;
    public float speed;
    Rigidbody2D rigid2d;

    // Start is called before the first frame update
    void Start()
    {
        //pos = transform.position;
        speed = 10;
        rigid2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //pos.x += 0.1f;
                //transform.position = pos;

                rigid2d.AddForce(new Vector2(speed, 0));
                GetComponent<SpriteRenderer>().flipX = false;
                GetComponent<Animator>().SetBool("Running", true);
            }
            else
            {
                //pos.x -= 0.1f;
                rigid2d.AddForce(new Vector2(-speed, 0));
                //transform.position = pos;
                GetComponent<SpriteRenderer>().flipX = true;
                GetComponent<Animator>().SetBool("Running", true);
            }
        }
        else
            GetComponent<Animator>().SetBool("Running", false);

        if (Input.GetKey(KeyCode.Space))
        {
            rigid2d.AddForce(new Vector2(0, 50));
        }
    }
}
