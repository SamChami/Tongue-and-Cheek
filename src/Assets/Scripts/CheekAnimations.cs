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
            if (body.transform.localEulerAngles.z != 0)
            {
                Quaternion rot = new Quaternion();
                rot.eulerAngles = new Vector3(0, 0, 0);
                transform.rotation = rot;
            } else
            {
                anim.SetBool("isUpright", true);
                body.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
        else
        {
            body.constraints = RigidbodyConstraints2D.None;
            anim.SetBool("isUpright", false);

            //         Debug.Log(transform.Find("tongue"));
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
