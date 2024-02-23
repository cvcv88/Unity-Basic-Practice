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
		// <���� ���ӿ�����Ʈ ����>
		thisGameObject = gameObject;
		thisName = gameObject.name;
		thisActive = gameObject.activeSelf; // �ν����� â���� ��/Ȱ��ȭ ���׳� ����
											// thisActive = gameObject.activeInHierarchy; // �θ�-�ڽ�, ���� Ȱ��ȭ, �θ� ��Ȱ��ȭ�� ���

		thisTag = gameObject.tag;
		thisLayer = gameObject.layer;
	}

	private void GameObjectFunction()
	{
		// <���ӿ�����Ʈ ����>
		// NewGameObject��� �̸��� ���� ������Ʈ ����!
		newGameObject = new GameObject("NewGameObject");

		// <���ӿ�����Ʈ ����>
		if (destroyGameObject != null)
		{
			Destroy(destroyGameObject);     // �׳� ����
			Destroy(destroyGameObject, 3f); // 3�� �ڿ� ���� ����
											// Missing ���·� �ٲ� == null
		}

		// <���ӿ�����Ʈ Ž��>
		// Find �̸� �� �� �������� �ʴ´�.
		// ���� 1. �̸��� ������ �Ȱ��ƾ� ��
		// ���� 2. ��� ���ӿ�����Ʈ�� Ž���ؾ� �Ѵ�. O(n)
		// Ư���� ���� ã�ƾ� ȿ���� -> Tag!
		// findWithName = GameObject.Find("MainCamera");   // �̸����� ã��
		findWithTag = GameObject.FindWithTag("Player");        // �±׷� ã��
	}

	private void ComponentFunction()
	{
		// <������Ʈ �߰�>
		// newComponent = new Rigidbody(); // �ǹ̾��� �ڵ�
		// ������Ʈ�� ���� ������Ʈ�� �����Ǿ� ���۵Ǿ�� �ǹ̰� �ִ�.
		// ������Ʈ ��ü�� ����� ���ӿ�����Ʈ�� ���̴� �� �ƴ�.
		addComponent = gameObject.AddComponent<Rigidbody>();


		// <������Ʈ ����>
		if (destroyComponent != null)
		{
			Destroy(destroyComponent);
		}

		// <������Ʈ Ž��> - ���ӿ�����Ʈ���� ã��
		getComponent = gameObject.GetComponent<Collider>();

		// <������Ʈ Ž��> - ������ ã��
		findComponent = GameObject.FindObjectOfType<Camera>();
	}
}
