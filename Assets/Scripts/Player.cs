using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Prime31;

public class Player : MonoBehaviour
{
    public float gravity = -10;
    public float moveSpeed = 10f;

    private CharacterController2D controller;
    private Animator anim;
    private SpriteRenderer spriteRend;
   

    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Run(inputH);
        Climb(inputV);

    }
    private void Run(float inputH)
    {
        controller.move(transform.right * inputH * moveSpeed * Time.deltaTime);
        bool isRunning = inputH != 0;
        anim.SetBool("isRunning", isRunning);

        spriteRend.flipX = inputH < 0;
    }

    void Climb(float inputV)
    {

    }
}
