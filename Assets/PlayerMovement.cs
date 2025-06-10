using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgb;    
    Vector3 velocity;

    float speedAmount = 0.5f;
    float jumpAmount = 3f;
    public float Acceleration = 2f;
    float currentacceleration;

    bool isGrounded;
    public LayerMask groundLayer;
    public float groundCheckSpace;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckSpace, groundLayer);
      Debug.Log(isGrounded);

         velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
         if (Input.GetKey(KeyCode.LeftShift)){
            currentacceleration = Acceleration;

         } else{
            currentacceleration = 1;
         }
         transform.position += velocity * speedAmount * currentacceleration * Time.deltaTime;
         

         if (Input.GetButtonDown("Jump") && isGrounded)
         {
            rgb.AddForce(Vector3.up * jumpAmount , ForceMode2D.Impulse);
            isGrounded = false;
         }
   }
   
   
    
   
}