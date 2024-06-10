using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    private float speedRock;
    private new Rigidbody2D rigidbody;
    public PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      

        rigidbody.velocity=new Vector2 (-16, -8);
        transform.Rotate (0, 0, 3);


        
    }


  
}
