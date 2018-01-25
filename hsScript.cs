using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hsScript : MonoBehaviour {
	//
	MainScript scripting;
	public Text Finalscore;
	private int finale;
	// Use this for initialization
	void Start () {
		//Finalscore = GetComponent<Text> () as Text;

//		scripting = GameObject.Find ("manage").GetComponent<MainScript> ();
//		finale = scripting.finalescore;
//		Finalscore.text = "Score :" + finale.ToString ();

	}

	public void replay(){
		//SceneManager.LoadScene ("gameplay");

	}
	// Update is called once per frame
	void Update () {
	
	}
}
