using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class CameraController : MonoBehaviour
{
	public Transform follow; // 누구를 따라다닐 건지
	public Vector3 offset; // 얼마만큼의 거리를 둘 건지

	private void Update()
	{
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}
}
