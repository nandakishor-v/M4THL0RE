using System;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
	[SerializeField] private AudioClip coinPickupSFX;
	[SerializeField] private int coinScore = 100;
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == 8)
		{
			AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position, 0.30f);
			AddCoinScore();
			Destroy(gameObject);
		}
	}

	private void AddCoinScore()
	{
		FindObjectOfType<GameSession>().AddToScore(coinScore);
	}
}
