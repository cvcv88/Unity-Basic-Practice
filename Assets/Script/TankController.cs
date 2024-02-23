using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
	public Transform turretTransform;
	public float turretRotateSpeed;

    public float moveSpeed;
    public float rotateSpeed;

    private Vector3 moveDir;
	private Vector3 turretDir;


	private void Update()
	{
		Move();
		HeadRotate();
	}

	private void Move()
	{
		transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
		transform.Rotate(0, moveDir.x * rotateSpeed * Time.deltaTime, 0, Space.Self);
	}
	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		moveDir.x = inputDir.x; // аб©Л
		moveDir.z = inputDir.y; // ╬у╣з
	}

	private void HeadRotate()
	{
		turretTransform.Rotate(Vector3.up, turretDir.x * turretRotateSpeed * Time.deltaTime, Space.Self);
		turretTransform.Rotate(Vector3.right, turretDir.z * -turretRotateSpeed * Time.deltaTime, Space.Self);
	}
	private void OnHeadRotate(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		turretDir.x = inputDir.x; // аб©Л
		turretDir.z = inputDir.y; // ю╖ ╬ф╥║
	}

	private void Fire()
	{

	}

	private void OnFire(InputValue value)
	{
		Fire();
	}
}
