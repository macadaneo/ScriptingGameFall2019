using UnityEngine;

public class Movement : MonoBehaviour
{
    public float gravity = 6f;
    public float speed = 20f;
    public float jumpSpeed = 45f;
    private int jumpCount = 2;
    
    private Vector3 position;
    public CharacterController controller;

     void Update()
     {
         position.x = speed * Input.GetAxis("Horizontal");

         if (!controller.isGrounded)
         {
             position.y -= gravity;
         }
         else
         {
             jumpCount = 2;
         }

         if (Input.GetButtonDown("Jump") && jumpCount > 0)
         {
             position.y = jumpSpeed;
             jumpCount--;
         }
         
         controller.Move(position*Time.deltaTime);
     }
}
