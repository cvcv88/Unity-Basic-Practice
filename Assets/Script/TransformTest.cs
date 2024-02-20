using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
	public Transform thisTransform;

	public bool isWorld;
	public float moveSpeed;

	// <트랜스폼 접근>
	private void /*Start()*/ TransformReference()
	{
		// thisTransform = transform;
		// 자기 자신에 붙어있는 transform을 가져온다.
	}

	// <트랜스폼 이동>
	private void Translate()
	{
		// position을 이용한 이동
		// 무조건 World를 기준으로 이동
		transform.position += new Vector3(1, 0, 0);

		// Translate를 이용한 이동, 위의 코드와 동일
		// World, Self 두가지 시점으로 이동 가능하다
		transform.Translate(1, 0, 0);

		// 월드를 기준으로 이동
		transform.Translate(1, 0, 0, Space.World);

		// 자신을 기준으로 이동
		transform.Translate(1, 0, 0, Space.Self);
	}


	// <트랜스폼 회전>
	private void Rotate()
	{
		// 월드를 기준으로 회전
		transform.Rotate(Vector3.up, 30, Space.World);

		// 자신을 기준으로 회전
		transform.Rotate(Vector3.up, 30, Space.Self);

		// 위치를 기준으로 회전
		// 0, 0, 0을 기준으로 30도 회전한다
		transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);

		// LookAt 위치를 바라보는 회전
		transform.LookAt(new Vector3(0, 0, 0)); 
	}

	// <트랜스폼 축>
	private void Axis()
	{
		// transform.right / up / forward

		// 트랜스폼의 x축
		Vector3 right = transform.right;

		// 트랜스폼의 y출
		Vector3 up = transform.up;

		// 트랜스폼의 z축
		Vector3 forward = transform.forward;
	}

	public Transform sphere;
	public Transform cube;

	private void Update()
	{
		/*float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		if (isWorld)
		{
			// transform.position += new Vector3(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime);
			transform.Translate(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime, Space.World);
		}
		else
		{
			// transform.position += new Vector3(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime);
			transform.Translate(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime, Space.Self);
		}*/

		// transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30 * Time.deltaTime);

		// transform.LookAt(new Vector3(0, 0, 0));

		/*// 스피어 위치 = transform 위치에 z 축 방향으로 +1 더하기
		sphere.position = transform.position + new Vector3(0, 0, 1);
		// cube 위치 = transform 위치에 forward 방향으로 더하기
		cube.position = transform.position + transform.forward;
		// transform이 가리키고 있는 앞방향으로의 +1, 파란색 선 방향으로 이동(self)*/

	}
}
