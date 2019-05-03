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
            if (transform.rotation.z < 5f)
            {
                anim.SetBool("isUpright", true);
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            else
            {
                anim.SetBool("isUpright", false);
            }

        }
        else
        {
            anim.SetBool("isUpright", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
        } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isLooking", true);
            anim.SetBool("isDucking", false);
            anim.SetBool("isWalking", false);
        } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
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
