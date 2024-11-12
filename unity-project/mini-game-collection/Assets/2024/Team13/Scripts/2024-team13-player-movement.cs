using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameCollection.Games2024.Team13
{
    public class PlayerMove : MonoBehaviour
    {
        //Movement variables
        public float moveSpeed = 5f;
        //A Vector3 to store the player's location. This is so we can calculate velocity
        private Vector3 movement;
        //Component variable for the rigidbody
        private Rigidbody rb;
        //Jump stuff
        public float jumpHeight = 8f;
        private bool isGrounded;
        public LayerMask groundLayer;
        // Start is called before the first frame update
        void Start()
        {
            //Initialize the RB variable
            rb = GetComponent<Rigidbody>();
            //Code to constrain rotation
            rb.freezeRotation = true;
        }
        private void Update()
        {
            //Check for collision with the ground layer using a Raycast (line collision)
            isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.5f, groundLayer);
            //If the player hits space, and they are on the ground, add a force to the rigidbody. ForceMode.Impulse means "immediate"
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z), ForceMode.Impulse);
            }
        }
        void FixedUpdate()
        {
            //Create two float variables for horizontal and vertical axes
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            //Send h and v to a custom function called Move
            Move(h, v);
        }
        void Move(float hSpeed, float vSpeed)
        {
            //Assign these values to the movement Vector3
            movement = (transform.forward * vSpeed) + (transform.right * hSpeed);
            //Normalize the movement vector and then multiply by movement speed and deltaTime
            movement = movement.normalized * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + movement);
        }
    }
}