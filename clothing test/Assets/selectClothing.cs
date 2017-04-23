using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class selectClothing : MonoBehaviour {

	public GameObject kimono;
	public GameObject tabi;
	public GameObject zori;
	public GameObject dirndl;
	public GameObject hat;
	public GameObject suspenders;
	public GameObject closedWardrobe;
	public GameObject openWardrobe;

	// definitions for clothes
	public GameObject tabiDef;
	public GameObject kimonoDef;
	public GameObject zoriDef;
	public GameObject hatDef;
	public GameObject suspendersDef;
	public GameObject dirndlDef;



	public int country = 0;

	// Update is called once per frame
	void Update () {
		closedWardrobe.SetActive (true);
		if (Input.GetKeyDown("space")){
			country++;
		}

		if (country == 1) {
			closedWardrobe.SetActive (false);
			openWardrobe.SetActive (true);
			kimono.SetActive (true);
			tabi.SetActive (true);
			zori.SetActive (true);

			if (Input.GetKeyDown ("left")) {
				tabiDef.SetActive (true);
				kimonoDef.SetActive (false);
				zoriDef.SetActive (false);
			}
			if (Input.GetKeyDown ("right")) {
				tabiDef.SetActive (false);
				kimonoDef.SetActive (true);
				zoriDef.SetActive (false);
			}
			else if (Input.GetKeyDown ("down")) {
				tabiDef.SetActive (false);
				kimonoDef.SetActive (false);
				zoriDef.SetActive (true);
			}
		}

		if (country == 2) {
			closedWardrobe.SetActive (false);
			tabiDef.SetActive (false);
			kimonoDef.SetActive (false);
			zoriDef.SetActive (false);
			kimono.SetActive (false);
			tabi.SetActive (false);
			zori.SetActive (false);
			dirndl.SetActive (true);
			hat.SetActive (true);
			suspenders.SetActive (true);

			if (Input.GetKeyDown ("left")) {
				hatDef.SetActive (true);
				dirndlDef.SetActive (false);
				suspendersDef.SetActive (false);
			}
			if (Input.GetKeyDown ("right")) {
				hatDef.SetActive (false);
				dirndlDef.SetActive (true);
				suspendersDef.SetActive (false);
			}
			else if (Input.GetKeyDown ("down")) {
				hatDef.SetActive (false);
				dirndlDef.SetActive (false);
				suspendersDef.SetActive (true);
			}

		}  if (country == 3) {
			hatDef.SetActive (false);
			dirndlDef.SetActive (false);
			suspendersDef.SetActive (false);
			dirndl.SetActive (false);
			hat.SetActive (false);
			suspenders.SetActive (false);
			openWardrobe.SetActive (false);
			closedWardrobe.SetActive (true);

		}

	}
}

