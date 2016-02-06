using UnityEngine;
using System.Collections;

public class BallSpawnScript : MonoBehaviour {

    private bool applied = false;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

	    if(!applied)
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(-75, 75), Random.Range(100,200), Random.Range(-350, -1000), ForceMode.VelocityChange);
            applied = true;
        }
    }
}
