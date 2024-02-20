using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
	public Transform thisTransform;

	public bool isWorld;
	public float moveSpeed;

	// <Ʈ������ ����>
	private void /*Start()*/ TransformReference()
	{
		// thisTransform = transform;
		// �ڱ� �ڽſ� �پ��ִ� transform�� �����´�.
	}

	// <Ʈ������ �̵�>
	private void Translate()
	{
		// position�� �̿��� �̵�
		// ������ World�� �������� �̵�
		transform.position += new Vector3(1, 0, 0);

		// Translate�� �̿��� �̵�, ���� �ڵ�� ����
		// World, Self �ΰ��� �������� �̵� �����ϴ�
		transform.Translate(1, 0, 0);

		// ���带 �������� �̵�
		transform.Translate(1, 0, 0, Space.World);

		// �ڽ��� �������� �̵�
		transform.Translate(1, 0, 0, Space.Self);
	}


	// <Ʈ������ ȸ��>
	private void Rotate()
	{
		// ���带 �������� ȸ��
		transform.Rotate(Vector3.up, 30, Space.World);

		// �ڽ��� �������� ȸ��
		transform.Rotate(Vector3.up, 30, Space.Self);

		// ��ġ�� �������� ȸ��
		// 0, 0, 0�� �������� 30�� ȸ���Ѵ�
		transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);

		// LookAt ��ġ�� �ٶ󺸴� ȸ��
		transform.LookAt(new Vector3(0, 0, 0)); 
	}

	// <Ʈ������ ��>
	private void Axis()
	{
		// transform.right / up / forward

		// Ʈ�������� x��
		Vector3 right = transform.right;

		// Ʈ�������� y��
		Vector3 up = transform.up;

		// Ʈ�������� z��
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

		/*// ���Ǿ� ��ġ = transform ��ġ�� z �� �������� +1 ���ϱ�
		sphere.position = transform.position + new Vector3(0, 0, 1);
		// cube ��ġ = transform ��ġ�� forward �������� ���ϱ�
		cube.position = transform.position + transform.forward;
		// transform�� ����Ű�� �ִ� �չ��������� +1, �Ķ��� �� �������� �̵�(self)*/

	}
}
