using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour {

    public float speed;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(hMove * speed, 0, 0);     
          
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collectitems.GlobalInstance.CollectedItem(collision.gameObject);
        Destroy(collision.gameObject);
    }
}
