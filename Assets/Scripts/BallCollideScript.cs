using UnityEngine;
using System.Collections;

public class BallCollideScript : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "tennis_racket")
        {
            /*Vector3 velocity = collision.gameObject.GetComponent<Rigidbody>().velocity;
            velocity.x *= 2;
            velocity.y *= 2;
            velocity.z *= 2;
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(velocity.x, velocity.y, velocity.z, ForceMode.Impulse);*/
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
