using UnityEngine;
using System.Collections;

public class SplashSceneManager : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		//少し待ってから遷移します
		Invoke ("ToLoginScene", 2f);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}

	void ToLoginScene ()
	{
		Application.LoadLevel ("LoginScene");
	}
}
