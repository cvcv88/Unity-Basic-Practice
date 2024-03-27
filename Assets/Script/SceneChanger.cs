using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
		// == SceneManager.LoadScene(1);

		SceneManager.LoadScene("GameScene", LoadSceneMode.Single); // Single : 기존의 씬을 모두 닫고 하나만 연다.
		SceneManager.LoadScene("GameScene", LoadSceneMode.Additive); // Additive : 기존의 씬에다가 다른 씬을 추가로 연다.

	}
}
