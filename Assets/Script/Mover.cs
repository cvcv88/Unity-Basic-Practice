using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigid;
    // 갖고있는 Rigidbody 컴포넌트를 참조한다.

    public float movePower;

	public Vector3 inputDir;

	// 실행 중 계속 돌아가는 함수, 프레임마다 호출되는 함수
	private void Update()
	{
		// Input : 입력에 대한 클래스
		// GetKey : 누르고 있는 중에 true가 return 하는 함수
		if (Input.GetKey(KeyCode.W)) // KeyCode 열거형으로 제공
		{
			// AddForce : 힘을 가해주는 함수
			// 방향 설정, 힘을 주는 방식
			// rigid.AddForce(Vector3.forward * movePower);
			// 좌우 X, 위아래 Y, 앞뒤 Z
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
