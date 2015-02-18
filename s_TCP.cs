using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Net.Sockets;

public class s_TCP : MonoBehaviour {
	internal Boolean socketReady = false;
	TcpClient mySocket;
	NetworkStream theStream;
	//StreamWriter theWriter;
	BinaryWriter theWriter;
	//StreamReader theReader;
	BinaryReader theReader;
	public string Host = "192.168.0.136";
	public Int32 Port = 55500;
	

	public void setupSocket() { 
		try {
			mySocket = new TcpClient (Host, Port); 
			theStream = mySocket.GetStream (); 
			theWriter = new BinaryWriter (theStream);// StreamWriter(theStream); 
			theReader = new BinaryReader (theStream);//StreamReader(theStream); 					
			socketReady = true;
						
		} catch (Exception e) {
			Debug.Log ("Socket error: " + e);
		}
			print (socketReady);

	} 

	public void writeSocket(string theLine) { 
		if (!socketReady) return;  
		theWriter.Write(theLine); 
		theWriter.Flush(); 
	} 

/*	public String readSocket() { 
		if (!socketReady) 
			return ""; 
		if (theStream.DataAvailable) 
			return theReader.ReadLine(); 
		return ""; 
	} */
	public SByte readSocket(){
		sbyte a = 00;
		if (!socketReady)
			return a;
		if (theStream.DataAvailable)
						return theReader.ReadSByte ();
		return a;
	}
	public void closeSocket() { 
		if (!socketReady) return; 
		theWriter.Close(); 
		theReader.Close(); 
		mySocket.Close(); 
		socketReady = false; 
	} 

	public void writeSocketBin(byte[] test) { 
		if (!socketReady) return; 

		theWriter.Write(test); 
		theWriter.Flush(); 
	}
	
	
	// Use this for initialization
	void Start () {

		setupSocket ();
		//byte a = System.Text.Encoding.UTF8.GetBytes ("LER1090");
		byte[] a = {76, 69, 82, 49, 10, 00, 231, 3, 0, 0};
		//print (a);
		writeSocketBin (a);

		//writeSocket ("TEST!!!!!");
		//writeSocket ("LER1090");
	}
	
	// Update is called once per frame
	void Update () {
		SByte test = readSocket();
		print (test);
	}

}
