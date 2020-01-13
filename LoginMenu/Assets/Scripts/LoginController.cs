using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour
{
	public InputField UsernameField;
	public InputField PasswordField;

	public GameObject ErrorText;

	public Button SignInBtn;

	private string username = "admin";
	private string password = "admin";

	void Awake() {
		SignInBtn.onClick.AddListener(LogIn);
	}

	void LogIn() {
		if (UsernameField.text.ToLower() == username && PasswordField.text.ToLower() == password)
		{
			ErrorText.SetActive(false);
			OpenAccountScene();
		}
		else
		{
			ShowErrorText();
		}
	}

	void OpenAccountScene() {
		var Account = GameObject.Find("AccauntScene");
		if (Account != null)
		{
			AccauntScene AccauntScene = Account.GetComponent<AccauntScene>();
			AccauntScene.Invoke("Open", 0.01f);
		}
	}

	void ShowErrorText() {
		UsernameField.text = "";
		PasswordField.text = "";
		ErrorText.SetActive(true);
		StartCoroutine(HideError());
	}

	IEnumerator HideError() {
		yield return new WaitForSeconds(3);
		ErrorText.SetActive(false);
	}
}
