using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

	// public float moveSpeed;
	public float movePower; // �����̴� ��, Speed X
	public float maxSpeed;
    public float rotateSpeed;
	public float bulletForce;

    private Vector3 moveDir;
	private Vector3 turretDir;


	private void Update()
	{
		// Move();
		HeadRotate();
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Move()
	{
		if(rigid.velocity.magnitude > maxSpeed)
		{
			rigid.velocity = rigid.velocity.normalized * maxSpeed;
		}

		Vector3 forceDir = transform.forward * moveDir.z;
		rigid.AddForce(forceDir * movePower, ForceMode.Force);
		transform.Translate(0, 0, moveDir.z * movePower * Time.deltaTime, Space.Self);

		transform.Rotate(0, moveDir.x * rotateSpeed * Time.deltaTime, 0, Space.Self);
	}
	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		moveDir.x = inputDir.x; // �¿�
		moveDir.z = inputDir.y; // �յ�
	}

	private void HeadRotate()
	{
		turretTransform.Rotate(Vector3.up, turretDir.x * turretRotateSpeed * Time.deltaTime, Space.Self);
		turretTransform.Rotate(Vector3.right, turretDir.z * -turretRotateSpeed * Time.deltaTime, Space.Self);
	}
	private void OnHeadRotate(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
		turretDir.x = inputDir.x; // �¿�
		turretDir.z = inputDir.y; // �� �Ʒ�
	}

	private void Fire()
	{
		Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;
		shootSound.Play();
	}

	private void OnFire(InputValue value)
	{
		Fire();
	}

	private void OnZoom(InputValue value)
	{
		if (value.isPressed) // ������ �� 
		{
			// �켱������ ����
			zoomCamera.Priority = 50;
		}
		else                // ������ ��
		{
			// �켱������ ����
			zoomCamera.Priority = 1;
		}
	}
}
