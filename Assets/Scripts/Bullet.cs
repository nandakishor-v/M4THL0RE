using System;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private PlayerMovement player;
	[SerializeField] private float bulletSpeed = 20f;
	private Rigidbody2D bulletRigidBody;
	private float xSpeed;
    void Start()
    {
	    player = FindObjectOfType<PlayerMovement>();
	    bulletRigidBody = GetComponent<Rigidbody2D>();
	    xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
	    bulletRigidBody.velocity = new Vector2(xSpeed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
	    if (other.gameObject.layer == 11)
	    {
		    Destroy((other.gameObject));
	    }
	    Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
	    Destroy(gameObject);
    }
}
