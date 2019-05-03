using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

    public float maxSpeed = 7;
    public float grappleTakeOffSpeed = 7;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject graphic;
    [SerializeField] private Animator animator;
    [SerializeField] private bool grappling;
    [SerializeField] private new AudioSource audio;
    [SerializeField] private AudioClip[] stepSounds;
    [SerializeField] private AudioClip[] grappleSounds;

    protected override void ComputeVelocity() {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");


        if (graphic) {
            if (move.x > 0.01f) {
                if (graphic.transform.localScale.x == -1) {
                    graphic.transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                }
            } else if (move.x > 0.01f) {
                if (graphic.transform.localScale.x == -1) {
                    graphic.transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                }
            }
        }


        if (animator) {
            animator.SetBool ("grounded", grounded);
            animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);
        }

        targetVelocity = move * maxSpeed;
    }

    void Footstep() {
      if (audio) {
            audio.PlayOneShot(stepSounds[Random.Range(0, stepSounds.Length)]);
            // Debug.Log("playStepSounds");
        }
    }

    void Grapple() {
        if (audio) {
            audio.PlayOneShot(grappleSounds[Random.Range(0, grappleSounds.Length)]);
            // Debug.Log("playGrappleSounds");
        }
    }
}
