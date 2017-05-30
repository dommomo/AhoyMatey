using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
using UnityEngine;


public class Player : NetworkBehaviour 
{
    private Vector3 inputValue;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (!isLocalPlayer) { return; }         //only move and apply changes to local player

        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer()
    {
        if (isLocalPlayer) {           
            GetComponent<Camera>().enabled = true;
        }        


    }
}
