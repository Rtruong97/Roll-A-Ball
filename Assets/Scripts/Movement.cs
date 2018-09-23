using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float min = 5f;
    public float max = 8f;

    void Start () {
        min = transform.position.x;
        max = transform.position.x + 12;
    }
	
	void Update () {
		        transform.position =new Vector3(Mathf.PingPong(Time.time*6, max-min)+min, transform.position.y, transform.position.z);

	}

}
