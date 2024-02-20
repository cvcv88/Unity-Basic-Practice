using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
	Vector3 moveDir;

	public Rigidbody rigid;

	private void Update()
	{
		Move();
	}

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		moveDir.x = inputDir.x;
		moveDir.z = inputDir.y;
	}
	private void Move()
	{
		transform.position += moveDir * 3f * Time.deltaTime;
	}

	private void OnJump(InputValue value)
	{
		Jump();
	}
	private void Jump()
	{
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
	}
}
