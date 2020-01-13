using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccauntScene : MonoBehaviour
{
	public Canvas Canvas;

	void Start() {
		Close();
	}

	void Open() {
		Canvas.gameObject.SetActive(true);
	}

	void Close() {
		Canvas.gameObject.SetActive(false);
	}
}
