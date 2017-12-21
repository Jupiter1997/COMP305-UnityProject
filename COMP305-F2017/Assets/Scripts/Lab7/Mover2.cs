using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour {

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
        float vMove = Input.GetAxis("Vertical");
        if (hMove!=0||vMove!=0)
        {
            rb.velocity = new Vector2(hMove, vMove) * speed;
            transform.eulerAngles = new Vector3(0, 0, (Mathf.Atan2(vMove, hMove) * Mathf.Rad2Deg) - 90);
        }
      
          
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
