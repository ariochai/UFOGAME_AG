using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    Rigidbody2D rbd2;
    private int count = 0;

    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector2 Movement = new Vector2(MoveHorizontal, MoveVertical);
        rbd2.AddForce(Movement * 5);

    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("PickUp"))
        {
            count = count + 1;
            Destroy(collision.gameObject);
        }
        }

    }

