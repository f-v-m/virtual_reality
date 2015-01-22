
using UnityEngine;
using System.Collections;

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPReceive : MonoBehaviour {
	
	// receiving Thread
	Thread receiveThread;
	
	// udpclient object
	UdpClient client;
	
	// public
	// public string IP = "127.0.0.1"; default local
	public int port; 
	
	// infos
	public string lastReceivedUDPPacket="";
	public string allReceivedUDPPackets=""; // clean up this from time to time!
	public string X="";
	public string Z="";
	public string Y="";
	public float x;
	public float y;
	public float z;
	
	
	// start from shell
	private static void Main()
	{
		UDPReceive receiveObj=new UDPReceive();
		receiveObj.init();
		
		string text="";
		do
		{
			text = Console.ReadLine();
		}
		while(!text.Equals("exit"));
	}
	// start from unity3d
	public void Start()
	{
		
		init();
	}
	

	
	// init
	private void init()
	{

		//print("UDPSend.init()");
		

		port = 8051;
		
		// status
		//print("Sending to 127.0.0.1 : "+port);
		//print("Test-Sending to this Port: nc -u 127.0.0.1  "+port+"");

		receiveThread = new Thread(
			new ThreadStart(ReceiveData));
		receiveThread.IsBackground = true;
		receiveThread.Start();
		
	}
	
	// receive thread
	private  void ReceiveData()
	{
		
		client = new UdpClient(port);
		while (true)
		{
			
			try
			{

				IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
				byte[] data = client.Receive(ref anyIP);
				

				string text = Encoding.UTF8.GetString(data);
				

				print(">> " + text);
				
				lastReceivedUDPPacket=text;
				
				// ....
				allReceivedUDPPackets=allReceivedUDPPackets+text;
				X = text.Split(' ')[1];
				x = Convert.ToSingle(X)/1000;
				Z = text.Split(' ')[2];
				z = Convert.ToSingle(Z)/1000;
				Y = text.Split(' ')[3];
				y = Convert.ToSingle(Y)/1000;
			}
			catch (Exception err)
			{
				print(err.ToString());
			}
		}
	}
	

	// getLatestUDPPacket
	// cleans up the rest
	public string getLatestUDPPacket()
	{
		allReceivedUDPPackets="";
		return lastReceivedUDPPacket;
	}


	void Update () {
		transform.position = new Vector3(x, y, z);	
	}
			



}



