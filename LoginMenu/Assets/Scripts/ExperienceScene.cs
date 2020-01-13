using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceScene : MonoBehaviour
{
	public Canvas Canvas;

	public Button BackButton;

	public Experience Experience;

	void Awake()
	{
		BackButton.onClick.AddListener(OpenAccountScene);
	}

	void OpenAccountScene()
	{
		var Account = GameObject.Find("AccauntScene");
		if (Account != null)
		{
			AccauntScene AccauntScene = Account.GetComponent<AccauntScene>();
			AccauntScene.Invoke("Open", 0.01f);
			Close();
		}
	}

	void Start()
	{
		Close();
	}

	void Open()
	{
		Canvas.gameObject.SetActive(true);
		Experience.Clear();
	}

	void Close()
	{
		Canvas.gameObject.SetActive(false);
	}
}
