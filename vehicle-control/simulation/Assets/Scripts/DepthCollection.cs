using UnityEngine;
using System.Collections;

public class DepthCollection : MonoBehaviour {

	private bool holdingKey = false;
	private string screenshotName = "screenshot.png";
	
	void Start () {
	}
	
	void Update () {
	
		if (Input.GetKey (KeyCode.C)) {
			// For collecting depth data.
			API.instance.SetOutput("collectKeyPressed", 1);
			holdingKey = true;
		}
		else {
			if (holdingKey) {
				screenshotName = "screenshot_"+System.DateTime.Now.ToString("%y%MM%d%H%M%ss")+".png";
				Application.CaptureScreenshot("Screenshots/"+screenshotName);
				holdingKey = false;
			}
			
			API.instance.SetOutput("collectKeyPressed", 0);
		}

	}
	
}
