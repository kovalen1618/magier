using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // 4.
    public Animator animator;

    // 6. AttackPoint reference
    public Transform attackPoint;
    public float attackRange = 0.05f;
    // Make it so only enemies are affected (optional)
    public LayerMask enemyLayers; // Layers - for multiple enemy layers

    // 13. Attack damage - remember, all of this can be moved to more respective destinations
    public float attackDamage = 1;

    // 1. Start is not necessary for player combat

    // Update is called once per frame
    void Update()
    {
        // 2.
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }


    // 3. Attack method
    void Attack()
    {
        // 5. Play an attack animation
        animator.SetTrigger("attack");

        // 7. Detect all enemies within range of attack. Method creates a circle from the point 
        // we choose with the radius we specify and collect all objects the circle hits
                                                             // Center Point         Radius       Targets
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);


        // 8. Apply damage to enemies by looping over the enemies in the hitEnemies array
        foreach (Collider2D enemy in hitEnemies)
        {
            // 9. Initially add a debug for testing
            // Debug.Log("We hit " + enemy.name);

            // 12. Process hit for enemy
            enemy.GetComponent<SmallGoblin>().ProcessHit(attackDamage);
        }
    }


    // 10. Function to show radius of circle in Unity Editor
    private void OnDrawGizmos()
    {   
        // 11. Condition to make function inoperable if there is no attackPoint so that we don't get any errrors
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}
