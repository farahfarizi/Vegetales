using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainScript : MonoBehaviour {

	public int score;
	public int life;
	public GameObject EndUI;
	public Text Finalscore;
	public Text currentScore;
	public int finalescore;
	// Use this for initialization
	void Start () {
		EndUI.SetActive (false);
		life = 3;
		score = 0;
		print(" "+life);

	}


	
	// Update is called once per frame
	void Update () {
		currentScore.text = "Score : " + score.ToString ();
		if(life==0){
			finalescore = score;
			EndUI.SetActive (true);
			Finalscore.text = "Your Score Is : " + finalescore.ToString ();

		}


}

	public void Replay(){

		SceneManager.LoadScene ("gameplay");
	}
}
