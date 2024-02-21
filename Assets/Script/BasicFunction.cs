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

	private void Start()
	{
        ThisFunction();
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
}
