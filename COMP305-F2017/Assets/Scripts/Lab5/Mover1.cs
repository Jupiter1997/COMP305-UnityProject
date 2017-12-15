using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour {

    public float speed;
    Rigidbody2D rb;
    private int fiftyCount= 0;
    private int hundredCount = 0;
    private int fiveHunCount = 0;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fiftyCount + hundredCount + fiftyCount);
    }
    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(hMove * speed, 0, 0); 
          
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag=="50")
        {
            fiftyCount += 1;
            Destroy(col.gameObject);
           
        }
        if (col.gameObject.tag == "100")
        {
            hundredCount += 1;
            Destroy(col.gameObject);

        }
        if (col.gameObject.tag == "500")
        {
            fiveHunCount += 1;
            Destroy(col.gameObject);

        }
      
    }
}
