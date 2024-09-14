using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Animator enemyAnimator;

=======

=======



    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private GameObject groundDetector;
    [SerializeField] private float rayDistance;
    [SerializeField] private Transform leftBoundary;
    [SerializeField] private Transform rightBoundary;


=======
=======
=======
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject groundDetector;
    [SerializeField] private float rayDistance;


    private int directionChanger = 1;

    private void Update()
    {
        patrolEnemy();
    }

    private void patrolEnemy()
    {
        enemyAnimator.SetBool("IsPatrol", true);
        transform.Translate(directionChanger * Vector2.right * moveSpeed * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(groundDetector.transform.position, Vector2.down, rayDistance);

        if (transform.position.x <= leftBoundary.position.x || transform.position.x >= rightBoundary.position.x)
        
=======

        if (transform.position.x <= leftBoundary.position.x || transform.position.x >= rightBoundary.position.x)
        
=======

        if (transform.position.x <= leftBoundary.position.x || transform.position.x >= rightBoundary.position.x)
        
=======
        if (!hit)


        {
            Vector3 scaleVector = transform.localScale;
            scaleVector.x *= -1;
            transform.localScale = scaleVector;
            directionChanger *= -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a PlayerMovement component
        PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.TakeDamage(); // Call TakeDamage on PlayerMovement
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }

        // Handle collision with other objects (e.g., walls, player)
        Vector3 scaleVector = transform.localScale;
        scaleVector.x *= -1;
        transform.localScale = scaleVector;
        directionChanger *= -1;

=======
=======
=======


    }
}
