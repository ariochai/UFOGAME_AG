using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    Rigidbody2D rbd2;
    // Start is called before the first frame update
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
        rbd2.AddForce(Movement*15);

    }
}
