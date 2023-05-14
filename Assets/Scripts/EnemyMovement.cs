using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 1f;
	private Rigidbody2D enemyRigidBody;
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        enemyRigidBody.velocity = new Vector2(moveSpeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    private void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRigidBody.velocity.x)), 1f);
    }
}
