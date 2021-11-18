using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGoblin : MonoBehaviour
{
    [SerializeField] float maxHealth = 3;
    float currentHealth;


    private void Start()
    {
        currentHealth = maxHealth;
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        BrokenShortSword brokenShortSword = other.gameObject.GetComponent<BrokenShortSword>();

        ProcessHit(brokenShortSword);
    }*/

    public void ProcessHit(float damage) 
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            // If animation for goblin death is needed: https://youtu.be/sPiVz1k-fEs?t=809
        }
    }

}











