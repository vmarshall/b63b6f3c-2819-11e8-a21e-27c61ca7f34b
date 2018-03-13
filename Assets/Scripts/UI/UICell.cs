using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICell : MonoBehaviour, IListCell {

	public Text text;


	private long number;


	public void Init(object data) {
		number = (long)data;
	}



	void Update() {
		text.text = number.ToString();
	}



}
