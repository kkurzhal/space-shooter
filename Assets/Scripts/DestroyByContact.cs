using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Boundary")
        {
            Debug.Log("tag of other: " + other.tag);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
