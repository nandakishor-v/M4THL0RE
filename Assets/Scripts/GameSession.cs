using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
	[SerializeField] private int playerLives = 3;
	[SerializeField] private int  score = 0;
	[SerializeField] private TextMeshProUGUI livesText;
	[SerializeField] private TextMeshProUGUI scoreText;
	private void Awake()
	{
		var gameSessionCount = FindObjectsOfType<GameSession>().Length;
		if (gameSessionCount > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
		
	}

	private void Start()
	{
		livesText.text = playerLives.ToString();
		scoreText.text = score.ToString();
	}

	public void ProcessPlayerDeath()
	{

		if (playerLives > 1)
		{
			TakeLife();
		}
		else
		{
			ResetGameSession();
		}
	}

	private void TakeLife()
	{
		playerLives--;
		//var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		//SceneManager.LoadScene(currentSceneIndex);
		livesText.text = playerLives.ToString();
	}

	private void ResetGameSession()
	{
		//FindObjectOfType<ScenePersist>().ResetScreenPersist();
		SceneManager.LoadScene(2);
		Destroy(gameObject);
	}

	public void AddToScore(int scorePoint)
	{
		score += scorePoint;
		scoreText.text = score.ToString();
	}
}
