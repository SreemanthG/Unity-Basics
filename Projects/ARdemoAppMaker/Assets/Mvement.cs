
using UnityEngine;

public class Mvement : MonoBehaviour {

    // Use this for initialization
    public Rigidbody tsform;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w")) {
            tsform.AddForce(-100 * Time.deltaTime, 100 * Time.deltaTime,0); }
        else if (Input.GetKey("s")) {
            tsform.AddForce(100 * Time.deltaTime, -100 * Time.deltaTime, 0);
        }
	}
    
}
