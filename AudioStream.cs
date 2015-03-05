/*using UnityEngine;

using System.Collections;

using System;

using System.Collections.Generic;

using System.Reflection;

using System.Runtime;

using System.Runtime.InteropServices;
using Un4seen.Bass;
using System.Windows.Forms;



public class AudioStream : MonoBehaviour 
	
{
	
	public  string url;
	
	private int stream;
	
	
	
	public enum flags {
		
		BASS_DEFAULT
		
	}
	
	
	
	public enum configs {
		
		
		
		BASS_CONFIG_NET_PLAYLIST=21
		
		
		
	}
	
	
	
	/*[DllImport("bass")]
	
	public static extern bool BASS_Init(int device, int freq, int flag,IntPtr hwnd, IntPtr clsid);
	
	/*

    [DllImport("bass")]

    public static extern bool BASS_SetConfig(configs config,int valuer);

 

    [DllImport("bass")]

    //public static extern Int32 BASS_StreamCreateURL(string url,int offset,   flags flag,  IntPtr user);

    public static extern Int32 BASS_StreamCreateURL (string url, int offset, flags Flag, IntPtr dproc, IntPtr user ) ;

 

    [DllImport("bass")]

    public static extern bool BASS_ChannelPlay(int steam,bool restart);

 

    [DllImport("bass")]

    public static extern bool BASS_StreamFree(int stream);

 

    [DllImport("bass")]

    public static extern bool BASS_Free();

 */
	
/*	
	
	void Start () 
		
	{
		try{
		
			BassNet.Registration ("vmfedorkovych@gmail.com", "2X17223123152222");	
			//			if ( Bass.BASS_Init(-1, 44100,0,IntPtr.Zero, IntPtr.Zero) ) {
			Bass.BASS_Init (0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero, Guid.Empty);// Bass.BASS_Init(-1, 44100,0,IntPtr.Zero, Guid.Empty)) {
			
			//			Bass.BASS_SetConfig(configs.BASS_CONFIG_NET_PLAYLIST,2);
			
			//Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PLAYLIST,1);
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_BUFFER, 100);
			//Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, 20);
			//			stream = Bass.BASS_StreamCreateURL(url, 0, flags.BASS_DEFAULT, IntPtr.Zero, IntPtr.Zero);
			//DOWNLOADPROC *down;
			//sinstream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
			stream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_MUSIC_MONO, null, IntPtr.Zero);
			
			//if (stream != 0) 
			Bass.BASS_ChannelPlay(stream, false);           
		}
		catch(TypeInitializationException){
			print("TypeInitializationException");
		}
		
	}
	
	
	
	
	
	void OnApplicationQuit()
		
	{
		
		//Bass.BASS_StreamFree(stream);
		
//		Bass.BASS_Free();
		
	}
	
}*/