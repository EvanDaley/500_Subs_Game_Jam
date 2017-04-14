using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTooltip : MonoBehaviour {

	public string tooltipContents;

	void OnTriggerEnter()
	{
		TooltipController.Instance.DisplayMessage (tooltipContents);
	}
}
