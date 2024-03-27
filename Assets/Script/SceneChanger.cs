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

		SceneManager.LoadScene("GameScene", LoadSceneMode.Single); // Single : ������ ���� ��� �ݰ� �ϳ��� ����.
		SceneManager.LoadScene("GameScene", LoadSceneMode.Additive); // Additive : ������ �����ٰ� �ٸ� ���� �߰��� ����.

	}
}
