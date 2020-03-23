using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisoinEnter2D (Collision2D other) {
        if (other.collider.name == "Tembokkanan" || other.collider.name == "Tembokkiri")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1,-1) * 30;
        }
     
        }


}
