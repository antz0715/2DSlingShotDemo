using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }
        
    }*/
    private bool spacePressed = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !spacePressed)
        {
            spacePressed = true;

            
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
        }
    }
}
