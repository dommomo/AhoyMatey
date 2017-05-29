using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager 
{
    // Use this for initialization
	void Start () 
	{

	}

    public void MyStartHost()
    {
        this.StartHost();
        Debug.Log(Time.timeSinceLevelLoad + " : Starting host");
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Host started");
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Client start requested");
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Client connected to local server : " + conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
