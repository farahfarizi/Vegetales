using UnityEngine;
using System.Collections;

public class vegeScript : MonoBehaviour {
	public int vegeType;
	public int vegeStage;
	//normal=0,butuh air=1, kering=2

	public int vegeGrowth;
	//tanah 0, kecil 1, ready to harvest2, sickling3, harvesting 4
	// Use this for initialization

	toggleManager script;
	MainScript script2;
	public bool click = false;
	bool seeding=false;
	bool watering = false;
	bool harvesting = false;
	bool sickle = false;

	void decideType(){
		var randomInt = Random.Range(0,3);
		vegeType = randomInt;

	}

	void newVege(){
		decideType ();
		vegeGrowth = 0;
		vegeStage = 0;
		print ("Type = " + vegeType);
		StartCoroutine (Seedtiming ());

	}

	public void clickDetect(){

		click = true;

	}




		
	void seedingOn(){
		
		if (vegeGrowth == 0) {
			if (script.seeds.isOn && click == true) {

				print ("seeding success");
				//seeding code
				seeding = true;
				click = false;
				vegeGrowth = 1;
				vegeStage = 0;
			} else {
				seeding = false;
				click = false;
				print ("not seeding");
			}
		}


		if (vegeGrowth == 1) {
			if (script.water.isOn && click == true) {
				print ("watering success");
				//watering code

				watering = true;
				click = false;
				vegeGrowth = 2;
				vegeStage = 0;

			} else {

				watering = false;
				click = false;
				print ("not watering");
			}
		}

		if (vegeGrowth == 2) {
			if (script.harvest.isOn && click == true) {
				print ("harvesting success");
				//watering code

				harvesting = true;
				click = false;
				vegeGrowth = 4;
				StartCoroutine (HarvestWait ());


			

			} else {

				harvesting = false;
				click = false;
				print ("not harvesting");
			}
		}

		if(vegeStage == 2){

			if (script.trash.isOn && click == true) {
				print ("cutting down success");
				//watering code

				sickle = true;
				click = false;
				vegeGrowth = 0;
				vegeStage = 0;
				//tambah score====

			} else {

				sickle = false;
				click = false;
				print ("not sickling unsucceed");
			}

		}

	}

/// <summary>
/// S////////////////////////////////////// </summary>

	IEnumerator HarvestWait(){
		yield return new WaitForSeconds (2);
		vegeGrowth = 0;
		vegeStage = 0;


		//tambah score====
		script2.score++;
		newVege ();
	}
	IEnumerator Seedtiming(){
		//SEEDING = from DIRT TO SMALL PLANT
		seedingOn ();


		if(vegeGrowth==0){

			seedingOn ();

		if (seeding == false) {
				seedingOn ();
			if (vegeType == 0) {

				yield return new WaitForSeconds (3);
				//print (Time.time);
				print ("stop time");
			} else if (vegeType == 1) {

				yield return new WaitForSeconds (5);
				//print (Time.time);
				print ("stop time");
			} else {
				yield return new WaitForSeconds (8);
				//print (Time.time);
				print ("stop time");
			}
			seedingOn ();
			print ("first time");


			if (seeding == false) {
					seedingOn ();
				if (vegeType == 0) {

					yield return new WaitForSeconds (4);
					//print (Time.time);
					print ("stop time");
				} else if (vegeType == 1) {

					yield return new WaitForSeconds (6);
					//print (Time.time);
					print ("stop time");
				} else {
					yield return new WaitForSeconds (8);
					//print (Time.time);
					print ("stop time");
				}

				vegeStage = 1;
				print ("whitering");

				seedingOn ();

				if (seeding == false) {
						seedingOn ();
					if (vegeType == 0) {

						yield return new WaitForSeconds (4);
						//print (Time.time);
						print ("stop time");
					} else if (vegeType == 1) {

						yield return new WaitForSeconds (6);
						//print (Time.time);
						print ("stop time");
					} else {
						yield return new WaitForSeconds (8);
						//print (Time.time);
						print ("stop time");
					}

					seedingOn ();

					if (seeding == false) {
							vegeStage = 2;

							seedingOn ();
					}

				}

			}
		}



		}


		////////////////////////////////////////////////////////////////////////////////////
		/// UKURAN SEDANG//////////////////

		if(vegeGrowth==1){

			if (watering == false) {

				if (vegeType == 0) {

					yield return new WaitForSeconds (4);
					//print (Time.time);
					print ("stop time");
				} else if (vegeType == 1) {

					yield return new WaitForSeconds (6);
					//print (Time.time);
					print ("stop time");
				} else {
					yield return new WaitForSeconds (8);
					//print (Time.time);
					print ("stop time");
				}
				seedingOn ();
				print ("first time");


				if (watering == false) {

					if (vegeType == 0) {

						yield return new WaitForSeconds (4);
						//print (Time.time);
						print ("stop time");
					} else if (vegeType == 1) {

						yield return new WaitForSeconds (6);
						//print (Time.time);
						print ("stop time");
					} else {
						yield return new WaitForSeconds (8);
						//print (Time.time);
						print ("stop time");
					}

					vegeStage = 1;
					print ("whitering");

					seedingOn ();

					if (watering == false) {

						if (vegeType == 0) {

							yield return new WaitForSeconds (4);
							//print (Time.time);
							print ("stop time");
						} else if (vegeType == 1) {

							yield return new WaitForSeconds (6);
							//print (Time.time);
							print ("stop time");
						} else {
							yield return new WaitForSeconds (8);
							//print (Time.time);
							print ("stop time");
						}

						seedingOn ();

						if (watering == false) {

							vegeStage = 2;
						}

					}

				}
			}

		}

		///////////////////////////////////////////////////////////////////////////////////
		/// 
		/// 
		/// 
		/// 
		/// 
		/// 
		/// 
		if(vegeGrowth==2){

			if (harvesting == false) {

				if (vegeType == 0) {

					yield return new WaitForSeconds (4);
					//print (Time.time);
					print ("stop time");
				} else if (vegeType == 1) {

					yield return new WaitForSeconds (6);
					//print (Time.time);
					print ("stop time");
				} else {
					yield return new WaitForSeconds (8);
					//print (Time.time);
					print ("stop time");
				}
				seedingOn ();
				print ("first time");


				if (harvesting == false) {

					if (vegeType == 0) {

						yield return new WaitForSeconds (4);
						//print (Time.time);
						print ("stop time");
					} else if (vegeType == 1) {

						yield return new WaitForSeconds (6);
						//print (Time.time);
						print ("stop time");
					} else {
						yield return new WaitForSeconds (8);
						//print (Time.time);
						print ("stop time");
					}

					vegeStage = 1;
					print ("whitering");

					seedingOn ();

					if (harvesting == false) {

						if (vegeType == 0) {

							yield return new WaitForSeconds (4);
							//print (Time.time);
							print ("stop time");
						} else if (vegeType == 1) {

							yield return new WaitForSeconds (6);
							//print (Time.time);
							print ("stop time");
						} else {
							yield return new WaitForSeconds (8);
							//print (Time.time);
							print ("stop time");
						}

						seedingOn ();

						if (harvesting == false) {
							vegeStage = 2;

						}

					}

				}
			}

		}
		////////////////////////sickling
		/// 
		/// 
		if (vegeStage==2) {
			

			if (vegeType == 0) {

				yield return new WaitForSeconds (4);
				//print (Time.time);
				print ("stop time");
			} else if (vegeType == 1) {

				yield return new WaitForSeconds (6);
				//print (Time.time);
				print ("stop time");
			} else {
				yield return new WaitForSeconds (8);
				//print (Time.time);
				print ("stop time");
			}

			seedingOn ();


			if (sickle == true) {
				print ("SICKLING OK");
				newVege ();


			} else {
				print ("sickling FAILURE");
				script2.life--;
				ifDies ();

			}


		}

		///////back to the beginning

	}

	void ifDies(){


		if (script2.life != 0) {
			newVege ();
		} else {
			print ("GAME OVER");
		}
	}

	void Start () {
		script = GameObject.Find ("toggleManage").GetComponent<toggleManager> ();
		script2 = GameObject.Find ("manage").GetComponent<MainScript> ();

		newVege ();
	}
	
	// Update is called once per frame
	void Update () {
		seedingOn ();
		if(click == true){
			print ("clickingg");
			seedingOn ();
		}
	}
}
