using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	//ゲームオブジェクトを呼び出す
	private GameObject CubeTag;
	private GameObject GroundTag;
	private GameObject UnityChan2D;

	//オーディオクリップのしてい
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();

	// Use this for initialization
	void Start () {
		//ゲームオブジェクトを取得
		this.CubeTag = GameObject.Find("CubeTag");
		this.GroundTag = GameObject.Find ("GroundTag");
		this.UnityChan2D = GameObject.Find ("UnityChan2D");

		audioSource = gameObject.AddComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {
		}

	//トリガーモードで他のオブジェクトと接触した場合の処理
	void OnCollisionEnter2D(Collision2D coll){
		//ブロックや地面にぶつかったとき音を鳴らす。
		if (gameObject.tag == "CubeTag" || gameObject.tag == "GroundTag") {
			audioSource.PlayOneShot (audioClip [0]);
		}
		//ユニティちゃんとぶつかったときは音は鳴らさない
		if (gameObject.tag == "UnityChan2D"){
			GetComponent<AudioSource> ().volume = 0;
	}
}
}
