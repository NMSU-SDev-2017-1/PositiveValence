using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenueController : MonoBehaviour {

    public Text hS; 

	// Use this for initialization
	void Start () {
        HsFunction();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    void HsFunction()
    {
        hS.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

}
