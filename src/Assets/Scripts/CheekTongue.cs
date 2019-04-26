using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheekTongue : MonoBehaviour
{

    DistanceJoint2D joint;
    Vector3 targetPosition;
    RaycastHit2D contact;

    public float distance = 100f;
    public LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;

            contact = Physics2D.Raycast(transform.position, targetPosition - transform.position, distance, mask);

            if (contact.collider != null)
            {
                Debug.Log("HIT");
                joint.enabled = true;

                //Vector2 connectPoint = contact.point + new Vector2(contact.collider.transform.position.x, contact.collider.transform.position.y);
                //connectPoint.x = connectPoint.x / contact.collider.transform.localScale.x;
                //connectPoint.y = connectPoint.y / contact.collider.transform.localScale.y;
                //Debug.Log(connectPoint);

                //joint.connectedAnchor = connectPoint;
                joint.connectedBody = contact.collider.gameObject.GetComponent<Rigidbody2D>();

                joint.distance = Vector2.Distance(transform.position, contact.point);
            } else
            {
                Debug.Log("MISS");
                Debug.Log(targetPosition.x);
                Debug.Log(targetPosition.y);


            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            joint.enabled = false;
        }
    }
}
