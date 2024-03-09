using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class CameraController : MonoBehaviour
{
	public Transform follow; // ������ ����ٴ� ����
	public Vector3 offset; // �󸶸�ŭ�� �Ÿ��� �� ����

	private void Update()
	{
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}
}
