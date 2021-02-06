using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private bool isAutoRotate;
	[SerializeField] private float rotateSpeed ;

    void Start()
    {
        
    }

    void Update()
    {
		if(Input.GetKey("up"))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if(Input.GetKey("down"))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if(Input.GetKey("right"))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if(Input.GetKey("left"))
		{
			transform.position -= Vector3.right * speed * Time.deltaTime;
		}


		var t = Time.realtimeSinceStartup;
		Vector3 r = new Vector3(t, t, t) * rotateSpeed;

		if(isAutoRotate)
		{
			this.transform.localEulerAngles = r;
		}
	}
}
