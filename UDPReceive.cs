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
	
	public int port; 

	public string X="";
	public string Z="";
	public float x;
	public float z;
		
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

		port = 8051;

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
				
				X = text.Split(' ')[1];
				x = Convert.ToSingle(X)/1000;
				Z = text.Split(' ')[2];
				z = Convert.ToSingle(Z)/1000;
			}
			catch (Exception err)
			{
				print(err.ToString());
			}
		}
	}

	void Update () {
		transform.position = new Vector3(x, 2f, z);	
	}

}



