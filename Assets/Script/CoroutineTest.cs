using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(JumpCoolTimeRoutine());
	}
	private void Update()
	{
		Debug.Log("Update");
	}

	IEnumerator JumpCoolTimeRoutine()
	{
		Debug.Log("점프 시작");
		yield return new WaitForSeconds(1f);
		Debug.Log("1");
		yield return new WaitForSeconds(1f);
		Debug.Log("2");
		yield return new WaitForSeconds(1f);
		Debug.Log("3");
		yield return new WaitForSeconds(1f);
		Debug.Log("점프 끝");
	}
}
