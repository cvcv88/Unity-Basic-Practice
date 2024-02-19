using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTest : MonoBehaviour
{
    [SerializeField] Transform trans;
	[SerializeField] Rigidbody rigid;
    [SerializeField] float moveSpeed;
	[SerializeField] float jumpPower;
    [SerializeField] float jumpCoolTime;
	public bool isJumpable;

    void Start()
    {
        Application.targetFrameRate = 60;    
    }

    void Update()
    {
        Move();
		// Jump();
		if (isJumpable && Input.GetKeyDown(KeyCode.Space))
		{
			rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
			StartCoroutine(JumpCoolTimeRoutine()); // ���� ���� üũ���� �ڷ�ƾ ����
		}
	}

    void Move()
    {
		Vector3 pos = trans.position;
		// trans.position.x = 0;
		// ������ �ƴ� ��ȯ���̿��� �̷� �������� �� �ٲٴ� �� �Ұ�����
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pos.x -= moveSpeed * Time.deltaTime;
			// ��ǻ�� ���� ���þ��� ��� ������ ������ ���� ����
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			pos.x += moveSpeed * Time.deltaTime;
		}
		trans.position = pos;
	}

    void Jump()
    {
		jumpCoolTime = 2f;

		jumpCoolTime += Time.deltaTime;

		if (jumpCoolTime >= 2f && Input.GetKey(KeyCode.Space))
		{
			// jumpCoolTime < 2f ���� �� �� ����
			rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
			jumpCoolTime = 0f;
		}
	}

	void CoroutineJump()
	{

	}

	IEnumerator JumpCoolTimeRoutine()
	{
		isJumpable = false;	// ���� ���� ���� false
		yield return new WaitForSeconds(jumpCoolTime);
		isJumpable = true; // ��Ÿ�� �ڿ��� true
	}
}
