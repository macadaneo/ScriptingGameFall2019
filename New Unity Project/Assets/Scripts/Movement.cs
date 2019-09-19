using System;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    public float gravity = 6f, speed = 20f, jumpSpeed = 45f;
    private int jumpCount, jumpCountMax = 2;
    
    private Vector3 position;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
     {
         position.x = speed * Input.GetAxis("Horizontal");
         position.y -= gravity;

         if (controller.isGrounded)
         {
             position.y = 0;
             jumpCount = 0;
         }
         
         if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
         {
             position.y = jumpSpeed;
             jumpCount++;
         }

         jumpSpeed = jumpCount == 1 ? 40f : 60f;
         
         
         controller.Move(position*Time.deltaTime);
     }
}
