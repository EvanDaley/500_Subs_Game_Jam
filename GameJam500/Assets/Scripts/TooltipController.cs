using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipController : MonoBehaviour {

	public static TooltipController Instance;
	public Text tooltipText;

	public float tooltipDuration = 2f;
	private float tooltipCooldown;

	void Awake () {
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
		if (Time.time > tooltipCooldown)
		{
			tooltipText.gameObject.SetActive (false);
		}
	}
}
