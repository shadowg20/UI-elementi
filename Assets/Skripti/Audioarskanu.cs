using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Audioarskanu : MonoBehaviour {
	public AudioSource mrBean;
	public AudioClip themeSong;
	public void hoverToBeanImage(){
		mrBean.PlayOneShot (themeSong);
	}
	public void NOThoverToBeanImage(){
		mrBean.Stop();
	}
}