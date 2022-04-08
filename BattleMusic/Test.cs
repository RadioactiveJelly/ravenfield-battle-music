using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public List<AudioSource> sources;
	public float volume = 1.0f;
	bool b = false;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 3; i++)
			sources[i].volume = volume;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(b)
			return;
		if(!sources[0].isPlaying && !sources[1].isPlaying)
			sources[1].Play();
		
		if(Input.GetKeyDown(KeyCode.U))
		{
			sources[1].Stop();
			sources[2].Play();
			b=true;
		}
	}
}
