using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEngine : MonoBehaviour
{
    public List<string> SceneNames;

	void Start(){
		for (int i = 0; i < SceneNames.Count; i++)
		{
			SceneManager.LoadScene(SceneNames[i], LoadSceneMode.Additive);
		}
		
	}
}
