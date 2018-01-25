using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleManager : MonoBehaviour {

	public Toggle seeds;
	public Toggle harvest;
	public Toggle trash;
	public Toggle water;

	public void ActiveToggle(){

		if(seeds.isOn){
			print ("seeding");

		}else if(harvest.isOn){
			print ("harvesting");

		}else if(trash.isOn){
			print ("recycling");

		}else if(water.isOn){
			print ("watering");

		}


	}
}
