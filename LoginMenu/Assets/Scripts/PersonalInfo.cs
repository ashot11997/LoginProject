using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonalInfo : MonoBehaviour
{
	//-----Accaunt Info Part
	private string name = "John Smith";
	private string about = "Software Engineer";
	private string address = "Armenia. Yerevan";
	private string longDesription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Egestas maecenas pharetra convallis posuere morbi leo. In fermentum et sollicitudin ac orci phasellus egestas. Egestas maecenas pharetra convallis posuere morbi leo urna molestie. Neque convallis a cras semper auctor neque vitae.";


	public Text Name;
	public Text About;
	public Text Address;
	public Text LongDescription;

	public Button OpenExperienceBtn;

	void Start() {
		SetupAccount();
	}

	void Awake()
	{
		OpenExperienceBtn.onClick.AddListener(OpenExperiencePart);
	}

	void SetupAccount() {
		Name.text = name;
		About.text = about;
		Address.text = address;
		LongDescription.text = longDesription;
	}

	void OpenExperiencePart()
	{
		var Experience = GameObject.Find("ExperienceScene");
		if (Experience != null)
		{
			ExperienceScene ExperienceScene = Experience.GetComponent<ExperienceScene>();
			ExperienceScene.Invoke("Open", 0.01f);
		}
	}
}
