﻿using System;
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

    Double tongueAngle;
    float tongueLength;
    double distanceFromOrigin;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        tongue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;

            contact = Physics2D.Raycast(transform.position, targetPosition - transform.position, distance, mask);

            if (contact.collider != null && contact.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                tongueLength = Vector2.Distance(transform.position, contact.point);
                distanceFromOrigin = contact.transform.position.y - transform.position.y;
                tongueAngle = (180 / Math.PI) * Math.Asin(distanceFromOrigin / tongueLength);
                Debug.Log(tongueAngle);
                // Hanging
                if (Double.IsNaN(tongueAngle) || tongueAngle > 50) {
                    Debug.Log("HIT");
                    joint.enabled = true;
                    tongue.enabled = true;
                    
                    joint.connectedBody = contact.collider.gameObject.GetComponent<Rigidbody2D>();
                    joint.connectedAnchor = contact.point - new Vector2(contact.collider.transform.position.x, contact.collider.transform.position.y);
                    joint.distance = tongueLength / 1.5f;


                    tongue.SetPosition(0, backOfMouth.transform.position);
                    tongue.SetPosition(1, contact.point);
                } else if (tongueAngle < 50)
                {
                    joint.enabled = true;
                    joint.connectedBody = contact.collider.gameObject.GetComponent<Rigidbody2D>();
                    joint.connectedAnchor = contact.point - new Vector2(contact.collider.transform.position.x, contact.collider.transform.position.y);
                    joint.distance = 0;
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
            joint.enabled = false;
            tongue.enabled = false;
        }
    }
    void FixedUpdate()
    {
        tongue.SetPosition(0, backOfMouth.transform.position - new Vector3(0, 0, backOfMouth.transform.position.z));

    }
}
