using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFrames : MonoBehaviour {

	public int frameRate = 25;
	public string folder = "ScreenshotsFolder";

	// Use this for initialization
	void Start () {
		Time.captureFramerate = frameRate;
		System.IO.Directory.CreateDirectory(folder);
	}
	
	// Update is called once per frame
	void Update () {
		// Append filename to folder name (format is '0005 shot.png"')
		string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);

		// Capture the screenshot to the specified file.
		Application.CaptureScreenshot(name);
	}
}
