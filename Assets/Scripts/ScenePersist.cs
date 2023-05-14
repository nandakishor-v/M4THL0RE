using UnityEngine;

public class ScenePersist : MonoBehaviour
{
	private void Awake()
	{
		var scenePersistCount = FindObjectsOfType<ScenePersist>().Length;
		if (scenePersistCount > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
		
	}

	public void ResetScreenPersist()
	{
		Destroy(gameObject);
	}
}
