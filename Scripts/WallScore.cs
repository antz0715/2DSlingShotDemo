using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class WallScore : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText;
    //public Rigidbody2D Circle;
    public Rigidbody2D Walls;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Walls"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
            Debug.Log(score);

        }
        if (score == 10)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScreen");
        }


    }
}