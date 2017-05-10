using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoin : MonoBehaviour {
	
	public  int coins = 0;
	public Text displayCoins;

	// Use this for initialization
	void Start () {
		coins = PlayerPrefs.GetInt ("Coins");
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("Coins", coins);
		displayCoins.text = coins.ToString();
	}
}
