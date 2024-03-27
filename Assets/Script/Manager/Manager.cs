using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] int FireCount;
	private static Manager instance;
	[SerializeField]
	DataManager dataManager;
	[SerializeField]
	GameManager gameManager;

	public static Manager GetInstance() { return instance; }
	public static Manager Inst { get { return instance; } }
	// �ٸ� �Ŵ����� ��� ������Ƽ�� �ν��Ͻ��� �Ŵ����� ������
	public static DataManager Data { get { return instance.dataManager; } }
	public static GameManager Game { get { return instance.gameManager; } }

	private void Awake()
	{
		// ���� �ϳ��� �ν��Ͻ��� �����Ͽ��ٸ�
		if (instance != null)
		{
			Debug.LogWarning("Singleton already exist");
			Destroy(this); // �̹� �ϳ��� �ν��Ͻ��� �����Ƿ� ���� �� �ν��Ͻ�(������Ʈ)�� ���ֹ���

			return;
		}
		instance = this;         // �����ٸ� ���� �� �ν��Ͻ�(������Ʈ)�� �̱��� �ν��Ͻ�(������Ʈ)
		DontDestroyOnLoad(this); // ���� ����Ǿ �� ������Ʈ�� �ı����� ����
	}
	private void OnDestroy()
	{
		if (instance == this)
		{
			instance = null;
		}
	}
	public void AddFireCount()
    {
        FireCount++;
    }
}
