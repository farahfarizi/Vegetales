using UnityEngine;
using System.Collections;

public class heartScript : MonoBehaviour {
	MainScript script;
	public GameObject heart;
	public GameObject heart1;
	public GameObject heart2;
	// Use this for initialization
	void Start () {
		script = GameObject.Find ("manage").GetComponent<MainScript> ();
		heart2.SetActive (true);
		heart1.SetActive (true);
		heart.SetActive (true);
	}

	
	// Update is called once per frame
	void Update () {
		if(script.life==2){
			heart2.SetActive (false);

		}
		if(script.life==1){
			heart2.SetActive (false);
			heart1.SetActive (false);

		}
		if (script.life == 0) {
			heart2.SetActive (false);
			heart1.SetActive (false);
			heart.SetActive (false);
		}

	}
}
