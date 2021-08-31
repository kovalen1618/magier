using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player1 : MonoBehaviour
{
    public float move_speed;
    public Rigidbody2D rig;
    public SpriteRenderer rend;

    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        rig.velocity = new Vector2(xInput * move_speed, yInput * move_speed);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode)) 
    }

    
     */
    public void GameOver() 
    {
        SceneManager.LoadScene("StartScreen");
    }
}

