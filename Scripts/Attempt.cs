using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Attempt : MonoBehaviour
{
    public TMP_Text scoreText;
    Vector2 startPos;

    //int score = 0;
    //Rigidbody2D rb;

    public Rigidbody2D Circle;
    //public Rigidbody2D Walls;
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //Debug.Log(startPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            var endPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //Debug.Log(endPos);

            var dir = ((endPos - startPos));
            var mag = Vector2.Distance(startPos, endPos);
            if (mag > 225)
            {
                mag =  225;
            }
            
            Circle.gravityScale = 1.75f;
            Circle.AddForce(-dir * mag * 0.00051f, ForceMode2D.Impulse);
            Debug.Log(mag);
            Debug.Log(dir);

        }
    }
    
    /*void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Walls"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString(); 


        }
    
    }*/
}
