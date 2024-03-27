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
	// 다른 매니저의 경우 프로퍼티로 인스턴스의 매니저를 쓰도록
	public static DataManager Data { get { return instance.dataManager; } }
	public static GameManager Game { get { return instance.gameManager; } }

	private void Awake()
	{
		// 만약 하나의 인스턴스가 존재하였다면
		if (instance != null)
		{
			Debug.LogWarning("Singleton already exist");
			Destroy(this); // 이미 하나의 인스턴스가 있으므로 지금 이 인스턴스(컴포넌트)를 없애버림

			return;
		}
		instance = this;         // 없었다면 지금 이 인스턴스(컴포넌트)가 싱글톤 인스턴스(컴포넌트)
		DontDestroyOnLoad(this); // 씬이 변경되어도 이 오브젝트는 파괴되지 않음
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
