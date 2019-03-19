using UnityEngine;
using System.Collections;

public class WeaponAttachment : MonoBehaviour
{

	//Weapon Gameojbect handler used to assign weapon
	public GameObject MainWeaponAttachment ;
	private GameObject WeaponSlot1;
	//Animator refrence
	Animator anim;	

	// Use this for initialization
	void Start ()
	{
		//Set the animator component for later use 
		anim = GetComponent<Animator>();

		//Check if weapon Exists and set its inital location 
		if (MainWeaponAttachment != null) {
			//Create an instanec of the weapon and set the state to idle
			WeaponSlot1 = Instantiate (MainWeaponAttachment, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
			//Attach the weapon to the desired bone or submesh make sure its a child to the player object
			WeaponSlot1.transform.parent = GameObject.Find ("bodyrahall").transform;
			//Set the desired idle position for the weapon
			WeaponSlot1.transform.localPosition = new Vector3(-0.0005f,0.0011f,0);
			//set the desired idle rotation for the weapon
			WeaponSlot1.transform.localEulerAngles  = new Vector3(6.97f,42.36f,90f); 
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		//Call update weapon state on every frame 
		UpdateWeaponState ();
	}

	//This function updates the weapon state and updates its position and rotation
	void UpdateWeaponState(){

		//Execute the following code if the current state is idle
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle")) {
			//Update weapon parent and position
			WeaponSlot1.transform.parent = GameObject.Find ("body rahall").transform;
			//Set the desired idle position for the weapon
			WeaponSlot1.transform.localPosition = new Vector3(-0.0005f,0.0011f,0);
			//set the desired idle rotation for the weapon
			WeaponSlot1.transform.localEulerAngles  = new Vector3(6.97f,42.36f,90f); 
		}

		//Execute the following code if the current state is Running
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Running")) {
			//Update Weapon parent and position
			WeaponSlot1.transform.parent = GameObject.Find ("Base HumanLPalmGizmo").transform;
			//Set the desired idle position for the weapon
			WeaponSlot1.transform.localPosition = new Vector3(-0.03f,-0.07f,-0.13f);
			//set the desired idle rotation for the weapon
			WeaponSlot1.transform.localEulerAngles  = new Vector3(6.97f,4f,211f); 
		}

	}
}