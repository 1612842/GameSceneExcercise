using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public GameObject test;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pos.x += 0.1f;
                transform.position = pos;
                GetComponent<SpriteRenderer>().flipX = false;
                GetComponent<Animator>().SetBool("Running", true);
            }
            else
            {
                pos.x -= 0.1f;
                transform.position = pos;
                GetComponent<SpriteRenderer>().flipX = true;
                GetComponent<Animator>().SetBool("Running", true);
            }
        }
        else
            GetComponent<Animator>().SetBool("Running", false);
    }
}
