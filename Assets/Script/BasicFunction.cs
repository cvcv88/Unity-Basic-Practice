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
        // <현재 게임오브젝트 참조>
        thisGameObject = gameObject;
        thisName = gameObject.name;
        thisActive = gameObject.activeSelf; // 인스펙터 창에서 비/활성화 시켰냐 여부
        // thisActive = gameObject.activeInHierarchy; // 부모-자식, 나는 활성화, 부모가 비활성화인 경우
        thisTag = gameObject.tag;
        thisLayer = gameObject.layer;
	}
}
