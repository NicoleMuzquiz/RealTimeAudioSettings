using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class addsoundStuffs : MonoBehaviour {
	GameObject obj;

	// Use this for initialization
	void Start () {
		obj = GameObject.FindGameObjectWithTag ("Sound");
	}

	public void addSound(GameObject obj){
		obj.AddComponent<SuperpoweredSpatializer> ();
		AudioSource voice = obj.AddComponent<AudioSource> ();
		AudioMixer master = Resources.Load ("spatializerreverb") as AudioMixer;
		voice.clip = Resources.Load ("speech") as AudioClip;

		voice.loop = true;
		voice.spatialize = true;
		voice.spatialBlend = 1.0f;
		voice.rolloffMode = AudioRolloffMode.Logarithmic;
		voice.maxDistance = 150;
		voice.minDistance = 1;
		voice.outputAudioMixerGroup = master.outputAudioMixerGroup;
		voice.playOnAwake = true;
	}
	
	// Update is called once per frame
	void Update () {
		addSound (obj);
	}
}
