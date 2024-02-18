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
			StartCoroutine(JumpCoolTimeRoutine()); // 점프 상태 체크해줄 코루틴 생성
		}
	}

    void Move()
    {
		Vector3 pos = trans.position;
		// trans.position.x = 0;
		// 변수가 아닌 반환값이여서 이런 형식으로 값 바꾸는 것 불가능함
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pos.x -= moveSpeed * Time.deltaTime;
			// 컴퓨터 사양과 관련없이 모두 동일한 움직임 구현 가능
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
			// jumpCoolTime < 2f 점프 할 수 없음
			rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
			jumpCoolTime = 0f;
		}
	}

	void CoroutineJump()
	{

	}

	IEnumerator JumpCoolTimeRoutine()
	{
		isJumpable = false;	// 점프 했을 때는 false
		yield return new WaitForSeconds(jumpCoolTime);
		isJumpable = true; // 쿨타임 뒤에는 true
	}
}
