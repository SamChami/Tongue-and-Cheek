using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheekTongue : MonoBehaviour
{
    public LineRenderer tongue;

    DistanceJoint2D joint;
    Vector3 targetPosition;
    RaycastHit2D contact;
    public GameObject backOfMouth;

    public float distance = 100f;
    public LayerMask mask;
    public Rigidbody2D cheek;

    Double tongueAngle;
    float tongueLength;
    double distanceFromOrigin;
    Vector3 scaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        cheek = GetComponent<Rigidbody2D>();
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        tongue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (joint == null) {
            this.gameObject.AddComponent<DistanceJoint2D>();
            joint = GetComponent<DistanceJoint2D>();
            joint.enabled = false;
            joint.enableCollision = true;
            joint.autoConfigureConnectedAnchor = false;
            joint.autoConfigureDistance = false;
            joint.maxDistanceOnly = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;
            
            contact = Physics2D.Raycast(transform.position, targetPosition - transform.position, distance, mask);

            if (contact.collider != null && contact.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                cheek.constraints = RigidbodyConstraints2D.None;

                scaleFactor = contact.collider.gameObject.transform.localScale;
                tongueLength = Vector2.Distance(transform.position, contact.point);
                distanceFromOrigin = contact.transform.position.y - transform.position.y;
                tongueAngle = (180 / Math.PI) * Math.Asin(distanceFromOrigin / tongueLength);

                tongue.enabled = true;
                tongue.SetPosition(0, backOfMouth.transform.position);
                tongue.SetPosition(1, contact.point);
                // Hanging
                if (Double.IsNaN(tongueAngle) || tongueAngle > 65) {
                    Debug.Log("Hang");
                    joint.enabled = true;
                    joint.connectedBody = contact.collider.gameObject.GetComponent<Rigidbody2D>();
                    joint.connectedAnchor = (contact.point - new Vector2(contact.collider.transform.position.x, contact.collider.transform.position.y)) / scaleFactor;
                    joint.distance = tongueLength / 1.5f;

                    Debug.Log(contact.point);
                    Debug.Log(contact.collider.transform.position);
                    Debug.Log(joint.connectedAnchor);
                }
                // Grapple
                else
                {
                    Debug.Log("Grapple");
                    Debug.Log(tongueAngle);
                    float direction = transform.position.x < contact.transform.position.x ? 1 : -1;

                    joint.enabled = true;
                    joint.connectedBody = contact.collider.gameObject.GetComponent<Rigidbody2D>();
                    joint.connectedAnchor = (contact.point - new Vector2(contact.collider.transform.position.x, contact.collider.transform.position.y)) / scaleFactor;
                    joint.distance = 0;
                    if (tongueAngle > 45)
                    {
                        joint.breakForce = 800f;
                        cheek.velocity = new Vector2(direction * 5f, 50f);
                    }
                    else
                    {
                        cheek.velocity = new Vector2(direction * 5f, 30f);
                    }
                }
            }
            else
            {
                Debug.Log("MISS");
                Debug.Log(targetPosition.x);
                Debug.Log(targetPosition.y);

            }
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            if (joint != null)
            {
                joint.enabled = false;
            }
            tongue.enabled = false;
        }

    }
    void FixedUpdate()
    {
        if (joint != null)
        {


            tongue.SetPosition(0, backOfMouth.transform.position - new Vector3(0, 0, backOfMouth.transform.position.z));
        } else
        {
            tongue.enabled = false;
        }

        if (!joint.enabled && transform.rotation.z != 0)
        {
            float tiltAngle = 60.0f;
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

            // Rotate the cube by converting the angles into a quaternion.
            Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            Quaternion q = transform.rotation;

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5f);
            cheek.rotation = 0;
            cheek.constraints = RigidbodyConstraints2D.FreezeRotation;

            //   transform.rotation.eulerAngles = new Vector3(0, 0, 0);


          //  transform.RotateAround(new Vector3 , Vector3.left, rotateSpeed * Time.deltaTime);
          //  Quaternion q = transform.rotation;
         //   q.eulerAngles = new Vector3(q.eulerAngles.x, q.eulerAngles.y, 0);
          //  transform.rotation = q;
        }
    }

    private void OnJointBreak2D(Joint2D joint)
    {
        tongue.enabled = false;
    }
}
