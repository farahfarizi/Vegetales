using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	// Use this for initialization


	public void load(){

		SceneManager.LoadScene ("gameplay",LoadSceneMode.Single);
	}
}
