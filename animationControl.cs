using UnityEngine;
using System.Collections;

public class animationControl : MonoBehaviour {
	vegeScript scripting;
	toggleManager scripting2;
	public GameObject turnip;
	public GameObject turnipidle1;
	public GameObject turnipgrow1;
	public GameObject turnipgrow2;
	public GameObject turnipidle2;
	public GameObject turnipharvested;
	public GameObject Tdecompose1;
	public GameObject Tdecompose2;
	public GameObject weed;
	int tempvegeType;
	int tempvegeStage;
	int tempvegeGrowth;

	void Start () {
		scripting = GameObject.Find ("dirt").GetComponent<vegeScript> ();
		scripting2 = GameObject.Find ("toggleManage").GetComponent<toggleManager> ();
		turnip.SetActive(false);

		makeFalse ();
		//getVegeType ();

		tempvegeType = scripting.vegeType;
		tempvegeStage = scripting.vegeStage;
		tempvegeGrowth = scripting.vegeGrowth;
	}


	void makeFalse(){



		turnipidle1.SetActive(false);
		turnipgrow1.SetActive(false);
		turnipgrow2.SetActive(false);
		turnipidle2.SetActive(false);
		turnipharvested.SetActive (false);
		Tdecompose1.SetActive(false);
		Tdecompose2.SetActive(false);
		weed.SetActive(false);
	}



	void getVegeType(){

		if (scripting.vegeType == 0) {
			print ("masuk ke vegetype");
			makeFalse ();
			turnip.SetActive (true);

			print ("OK");

	
			////////////tanah dibibitin
			if (scripting.vegeGrowth==0 && scripting.click == true && scripting2.seeds.isOn) {
				print ("growing");
				turnipgrow1.SetActive (true);

			}
				
				
			///////tumbuhan kecil idle
			if(scripting.vegeGrowth==1){

				if (scripting2.water.isOn && scripting.click == true) {
					print ("growing bigger");
					makeFalse ();
					turnipgrow2.SetActive (true);

				} 



				if (scripting.vegeStage == 0 || scripting.vegeStage==1) {
					
					makeFalse ();
					turnipidle1.SetActive (true);
				} 



				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose1.SetActive (true);

				} 




			}

			if(scripting.vegeGrowth==2){
				

				if (scripting.vegeStage == 0||scripting.vegeStage==1) {
					makeFalse ();
					turnipidle2.SetActive (true);
				} 


				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose2.SetActive (true);

				}

			}

			if (scripting.vegeGrowth==4) {
				makeFalse ();
				turnipharvested.SetActive (true);

			} 
				
			if (scripting.vegeGrowth==0&&scripting.vegeStage == 2) {
				makeFalse ();
				weed.SetActive (true);
			}
				
		}


		/////////jenis VEGE 2

		else if(scripting.vegeType==1){

			print ("masuk ke vegetype");
			makeFalse ();
			turnip.SetActive (true);

			print ("OK");


			////////////tanah dibibitin
			if (scripting.vegeGrowth==0 && scripting.click == true && scripting2.seeds.isOn) {
				print ("growing");
				turnipgrow1.SetActive (true);

			}
				
			///////tumbuhan kecil idle
			if(scripting.vegeGrowth==1){

				if (scripting2.water.isOn && scripting.click == true) {
					print ("growing bigger");
					makeFalse ();
					turnipgrow2.SetActive (true);

				} 



				if (scripting.vegeStage == 0 || scripting.vegeStage==1) {

					makeFalse ();
					turnipidle1.SetActive (true);
				} 



				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose1.SetActive (true);

				} 




			}

			if(scripting.vegeGrowth==2){


				if (scripting.vegeStage == 0||scripting.vegeStage==1) {
					makeFalse ();
					turnipidle2.SetActive (true);
				} 


				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose2.SetActive (true);

				} 

			}

			if (scripting.vegeGrowth==4) {
				makeFalse ();
				turnipharvested.SetActive (true);

			} 



			if (scripting.vegeGrowth==0&&scripting.vegeStage == 2) {
				makeFalse ();
				weed.SetActive (true);
			}


		}

		/////////jenis VEGE 3

		else{

			print ("masuk ke vegetype");
			makeFalse ();
			turnip.SetActive (true);

			print ("OK");


			////////////tanah dibibitin
			if (scripting.vegeGrowth==0 && scripting.click == true && scripting2.seeds.isOn) {
				print ("growing");
				turnipgrow1.SetActive (true);

			}

			///////tumbuhan kecil idle
			if(scripting.vegeGrowth==1){

				if (scripting2.water.isOn && scripting.click == true) {
					print ("growing bigger");
					makeFalse ();
					turnipgrow2.SetActive (true);

				} 



				if (scripting.vegeStage == 0 || scripting.vegeStage==1) {

					makeFalse ();
					turnipidle1.SetActive (true);
				} 



				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose1.SetActive (true);

				} 
					
			}

			if(scripting.vegeGrowth==2){


				if (scripting.vegeStage == 0||scripting.vegeStage==1) {
					makeFalse ();
					turnipidle2.SetActive (true);
				} 


				if (scripting.vegeStage == 2) {
					makeFalse ();
					Tdecompose2.SetActive (true);

				} 
					

			}

			if (scripting.vegeGrowth==4) {
				makeFalse ();
				turnipharvested.SetActive (true);

			} 



			if (scripting.vegeGrowth==0&&scripting.vegeStage == 2) {
				makeFalse ();
				weed.SetActive (true);
			}

		}
		}

	void Update(){
		print ("VType="+scripting.vegeType);
		print ("VStage="+scripting.vegeStage);
		print ("VGrowth="+scripting.vegeGrowth);

		/*tempvegeType = scripting.vegeType;
		tempvegeStage = scripting.vegeStage;
		tempvegeGrowth = scripting.vegeGrowth;
*/

		if(tempvegeType != scripting.vegeType ||
			tempvegeStage != scripting.vegeStage ||
			tempvegeGrowth != scripting.vegeGrowth){

			print ("VType="+scripting.vegeType);
			print ("VStage="+scripting.vegeStage);
			print ("VGrowth="+scripting.vegeGrowth);



			tempvegeType = scripting.vegeType;
			tempvegeStage = scripting.vegeStage;
			tempvegeGrowth = scripting.vegeGrowth;

			getVegeType ();


		}




	}

}
