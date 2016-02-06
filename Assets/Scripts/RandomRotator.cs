using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    public float tumble;

	void Start () {
        Rigidbody rgbd = GetComponent<Rigidbody>();
        rgbd.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
