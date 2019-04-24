using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheekAnimations : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("grounded"))
        {
            body.constraints = RigidbodyConstraints2D.FreezeRotation;
            // body.rotation = 0;

        }
        else
        {
            body.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isWalking", true);
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isLooking", true);
            anim.SetBool("isDucking", false);
            anim.SetBool("isWalking", false);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isLooking", false);
            anim.SetBool("isWalking", false);
            anim.SetBool("isDucking", true);
        } else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isDucking", false);
            anim.SetBool("isLooking", false);

        }


    }
}
