using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGoblin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon")) 
        {
            Debug.Log("it should work");
        }
    }









    public int ghp;
    /*
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    //

    }
    */
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
       // if (collision.gameObject.CompareTag("Weapon"))
        //{
          // Debug.Log("it should be funtioning");
          // ghp -= 1;
          // //new WaitForSeconds(1f);
          // if (ghp == 0)
          //  {
          //    Destroy(gameObject);

          //  }
       // }
   // }
    // collision.gameObject.GetComponent<player1>().GameOver();

}

