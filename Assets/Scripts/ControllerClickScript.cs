using UnityEngine;
using System.Collections;

public class ControllerClickScript : MonoBehaviour {

    public Transform prefab;

    public GameObject controllerObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var controller = SteamVR_Controller.Input(3);

        if(controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Grip))
        {
            Instantiate(prefab, new Vector3(200, 50, 600), new Quaternion());
        }
    }
}
