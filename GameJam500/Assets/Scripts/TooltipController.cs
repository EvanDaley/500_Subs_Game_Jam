using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipController : MonoBehaviour {

	public static TooltipController Instance;
	public Text tooltipText;

	public float tooltipDuration = 1f;
	private float tooltipCooldown;

	void Start () {
		Instance = this;

		tooltipText.gameObject.SetActive (false);
	}

	public void DisplayMessage(string message)
	{
		tooltipText.text = message;
		tooltipText.gameObject.SetActive (true);

		tooltipCooldown = Time.time + tooltipDuration;
	}

	void Update()
	{
		if (Time.time > tooltipCooldown || Input.GetKeyDown(KeyCode.E))
		{
			tooltipText.gameObject.SetActive (false);
		}
	}
}
