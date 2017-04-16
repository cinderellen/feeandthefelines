using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class book : MonoBehaviour {

	public GameObject phrase1;
	public GameObject phrase2;
	public GameObject phrase3;

	public int phraseCount = 1;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			phraseCount++;
		}


		if (phraseCount == 1) {
			phrase1.SetActive (true);
		} else if (phraseCount == 2) {
			phrase1.SetActive (false);
			phrase2.SetActive (true);
		} else if (phraseCount == 3) {
			phrase2.SetActive (false);
			phrase3.SetActive (true);
		} 

		else if (phraseCount == 4) {
			phraseCount = 1;
		}


	}
}


