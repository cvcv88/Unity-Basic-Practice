using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
	public Rigidbody rigid;

	public Transform firePoint;
	// public GameObject bulletPrefab;
	public Bullet bulletPrefab;

	public Transform turretTransform;
	public float turretRotateSpeed;

	public CinemachineVirtualCamera normalCamera;
	public CinemachineVirtualCamera zoomCamera;

	public AudioSource shootSound;

	public Animator animator;

	// public float moveSpeed;
	public float movePower; // 움직이는 힘, Speed X
	public float maxSpeed;
	public float rotateSpeed;
	public float bulletForce;

	private Vector3 moveDir;
	private Vector3 turretDir;

	public UnityEvent OnFired; // OnFireExit
	public UnityEvent OnFiring; // OnFireEnter

	private void Update()
	{
		Move();
		Rotate();
		Head();
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Move()
	{
		Vector3 forceDir = transform.forward * moveDir.z;
		rigid.AddForce(forceDir * movePower, ForceMode.Force);

		if (rigid.velocity.magnitude > maxSpeed)
		{
			rigid.velocity = rigid.velocity.normalized * maxSpeed;
		}

		//transform.Translate(0, 0, moveDir.z * movePower * Time.deltaTime, Space.Self);
		//transform.Rotate(0, moveDir.x * rotateSpeed * Time.deltaTime, 0, Space.Self);
	}

	private void Rotate()
	{
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World);
	}

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		moveDir.x = inputDir.x; // 좌우
		moveDir.z = inputDir.y; // 앞뒤
		Debug.Log(moveDir);
	}

	private void Head()
	{
		turretTransform.Rotate(Vector3.up, turretDir.x * turretRotateSpeed * Time.deltaTime, Space.Self);
		turretTransform.Rotate(Vector3.right, turretDir.z * -turretRotateSpeed * Time.deltaTime, Space.Self);
	}
	private void OnHeadRotate(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		turretDir.x = inputDir.x; // 좌우
		turretDir.z = inputDir.y; // 위 아래
	}
	public void Fire()
	{
		OnFiring?.Invoke();

		Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;
		shootSound.Play();
		animator.SetTrigger("Fire");

		// Manager.GetInstance().AddFireCount();
		Manager.Data.AddFireCount();
		Manager.Game.GamePause();

		OnFired?.Invoke();
	}

	private void OnFire(InputValue value)
	{
		Fire();
	}

	private void OnZoom(InputValue value)
	{
		if (value.isPressed) // 눌렀을 때 
		{
			// 우선순위를 높게
			zoomCamera.Priority = 50;
		}
		else                // 떼었을 때
		{
			// 우선순위를 낮게
			zoomCamera.Priority = 1;
		}
	}
}
