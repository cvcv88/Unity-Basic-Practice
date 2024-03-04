using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
	public float force;

	private void Start()
	{
		Destroy(gameObject, 5f);
		rigid.AddForce(transform.forward * force, ForceMode.Impulse);
	}
}
