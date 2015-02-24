using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

public class TCPreceive : MonoBehaviour {
	public int port;
	public string host;

	Thread receiveThread;
	TcpClient socket;
	NetworkStream stream;
	StreamReader strReader;
	BinaryReader binReader;
	BinaryWriter binWriter;

	bool socketReady;

	public void setupSocket() { 
		try {
			socket = new TcpClient (host, port); 
			stream = socket.GetStream (); 
			binWriter = new BinaryWriter (stream);// StreamWriter(theStream); 
			binReader = new BinaryReader (stream);//StreamReader(theStream); 
			strReader = new StreamReader (stream);
			socketReady = true;
			
		} catch (Exception e) {
			Debug.Log ("Socket error: " + e);
		}
		print (socketReady);
		
	} 

	public void ReceiveData(){
		socket = new TcpClient (host, port);
		IPAddress adr = IPAddress.Parse ("127.0.0.1");
		while (true) {
			IPEndPoint  t = new IPEndPoint(adr, port);

		}
	
	
	}

	public Byte[] readSocket(){
		byte[] a = null;
		if (!socketReady) {
			print ("Sock not ready");
			return a;
		}
		if (stream.DataAvailable) {
			return binReader.ReadBytes(16);	
		}
		return a;
	}

	public void WriteSocketBin(byte[] data){
		if (!socketReady)
						return;
		binWriter.Write (data);
		binWriter.Flush ();
	}

	public void closeSocket() { 
		if (!socketReady) return; 
		binWriter.Close(); 
		binReader.Close(); 
		strReader.Close ();
		socket.Close();

		socketReady = false; 
	} 
}
