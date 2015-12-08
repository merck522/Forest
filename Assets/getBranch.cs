using UnityEngine;
using System.Collections;

public class getBranch : MonoBehaviour {

	private float reach = 14.0f;
	public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		int layerMask = 1 << 8;

		if (Physics.Raycast (this.transform.position, this.transform.forward, out hit, reach, layerMask)) {
			Debug.Log ("Branch");
			hit.transform.GetComponent<Collider>().enabled = false;
			hit.transform.gameObject.layer = 0;
			hit.transform.GetComponent<Rigidbody>().useGravity = false;
			hit.transform.GetComponent<Rigidbody>().isKinematic = true;
			hit.transform.position = this.transform.position;
			hit.transform.parent = cam.transform;
			//hit.transform.position = this.transform.position;
			hit.transform.GetComponent<AudioSource>().Play(); 
		}
	}
}
