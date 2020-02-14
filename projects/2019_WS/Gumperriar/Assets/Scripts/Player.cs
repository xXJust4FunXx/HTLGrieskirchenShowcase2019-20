using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  public float speed = 5;
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Right, Left
    float x = Input.GetAxisRaw("Horizontal");

    // Up, Down
    //float y = Input.GetAxisRaw("Vertical");

    // Get the direction of movement
    Vector2 direction = new Vector2(x, 0).normalized;

    // Assign the movement speed and direction
    GetComponent<Rigidbody2D>().velocity = direction * speed;
    
    GetComponent<BoxCollider2D>().
    GetComponent<Colli>
  }
}
