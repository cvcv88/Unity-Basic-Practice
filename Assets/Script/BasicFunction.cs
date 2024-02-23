using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFunction : MonoBehaviour
{
	[Header("This")]
	public GameObject thisGameObject;
	public string thisName;
	public bool thisActive;
	public string thisTag;
	public int thisLayer;

	[Header("GameObject")]
	public GameObject newGameObject;
	public GameObject destroyGameObject;
	public GameObject findWithName;
	public GameObject findWithTag;

	[Header("Component")]
	public Component newComponent;
	public Component addComponent;
	public Component destroyComponent;
	public Component getComponent;
	public Component findComponent;

	private void Start()
	{
		ThisFunction();
		GameObjectFunction();
		ComponentFunction();
	}
	private void ThisFunction()
	{
		// <현재 게임오브젝트 참조>
		thisGameObject = gameObject;
		thisName = gameObject.name;
		thisActive = gameObject.activeSelf; // 인스펙터 창에서 비/활성화 시켰냐 여부
											// thisActive = gameObject.activeInHierarchy; // 부모-자식, 나는 활성화, 부모가 비활성화인 경우

		thisTag = gameObject.tag;
		thisLayer = gameObject.layer;
	}

	private void GameObjectFunction()
	{
		// <게임오브젝트 생성>
		// NewGameObject라는 이름의 게임 오브젝트 생성!
		newGameObject = new GameObject("NewGameObject");

		// <게임오브젝트 삭제>
		if (destroyGameObject != null)
		{
			Destroy(destroyGameObject);     // 그냥 삭제
			Destroy(destroyGameObject, 3f); // 3초 뒤에 삭제 예약
											// Missing 상태로 바뀜 == null
		}

		// <게임오브젝트 탐색>
		// Find 이름 은 잘 쓰이지는 않는다.
		// 이유 1. 이름이 완전히 똑같아야 함
		// 이유 2. 모든 게임오브젝트를 탐색해야 한다. O(n)
		// 특별한 것을 찾아야 효율적 -> Tag!
		// findWithName = GameObject.Find("MainCamera");   // 이름으로 찾기
		findWithTag = GameObject.FindWithTag("Player");        // 태그로 찾기
	}

	private void ComponentFunction()
	{
		// <컴포넌트 추가>
		// newComponent = new Rigidbody(); // 의미없는 코드
		// 컴포넌트는 게임 오브젝트에 부착되어 동작되어야 의미가 있다.
		// 컴포넌트 자체만 만들고 게임오브젝트에 붙이는 것 아님.
		addComponent = gameObject.AddComponent<Rigidbody>();


		// <컴포넌트 삭제>
		if (destroyComponent != null)
		{
			Destroy(destroyComponent);
		}

		// <컴포넌트 탐색> - 게임오브젝트에서 찾기
		getComponent = gameObject.GetComponent<Collider>();

		// <컴포넌트 탐색> - 씬에서 찾기
		findComponent = GameObject.FindObjectOfType<Camera>();
	}
}
