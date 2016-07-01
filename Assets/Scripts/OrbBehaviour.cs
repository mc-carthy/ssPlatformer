using UnityEngine;

public class OrbBehaviour : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {
		Destroy(this.gameObject);
	}
}