using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigid;
    // �����ִ� Rigidbody ������Ʈ�� �����Ѵ�.

    public float movePower;

	public Vector3 inputDir;

	// ���� �� ��� ���ư��� �Լ�, �����Ӹ��� ȣ��Ǵ� �Լ�
	private void Update()
	{
		// Input : �Է¿� ���� Ŭ����
		// GetKey : ������ �ִ� �߿� true�� return �ϴ� �Լ�
		if (Input.GetKey(KeyCode.W)) // KeyCode ���������� ����
		{
			// AddForce : ���� �����ִ� �Լ�
			// ���� ����, ���� �ִ� ���
			// rigid.AddForce(Vector3.forward * movePower);
			// �¿� X, ���Ʒ� Y, �յ� Z
			inputDir.z = 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			// rigid.AddForce(Vector3.back * movePower);
			inputDir.z = -1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			// rigid.AddForce(Vector3.left * movePower);
			inputDir.x = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			// rigid.AddForce(Vector3.right * movePower);
			inputDir.x = 1;
		}
	}

	private void FixedUpdate()
	{
		rigid.AddForce(inputDir * movePower);
	}

}
