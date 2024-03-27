using UnityEngine;

public class GameManager : MonoBehaviour
{
	public void GamePause()
	{
		Time.timeScale = 0f;
	}

	public void GameResume()
	{
		Time.timeScale = 1f;
	}
}

