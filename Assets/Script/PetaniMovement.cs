using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetaniMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpForce = 50f;

    }

    public void Jump()
    {
        if (rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

}
