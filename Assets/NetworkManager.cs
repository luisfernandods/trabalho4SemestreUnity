using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class NetworkManager : MonoBehaviour {


	public SocketIOComponent socket;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		socket.Emit ("jogando", JSONObject.CreateStringObject("Luis") );
	}

}
	