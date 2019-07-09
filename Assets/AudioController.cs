using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	//ゲームオブジェクトを呼び出す
	private GameObject CubeTag;
	private GameObject GroundTag;
	private GameObject UnityChan2DTag;

	//オーディオクリップのしてい
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();

	// Use this for initialization
	void Start () {
		//ゲームオブジェクトを取得
		this.CubeTag = GameObject.Find("CubeTag");
		this.GroundTag = GameObject.Find ("GroundTag");
		this.UnityChan2DTag = GameObject.Find ("UnityChan2DTag");

		audioSource = gameObject.AddComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {
		}

	//コライダーモードで他のオブジェクトと接触した場合の処理
	void OnCollisionEnter2D(Collision2D coll){
		//ブロックや地面にぶつかったとき音を鳴らす。
		if (coll.gameObject.tag == "CubeTag" || coll.gameObject.tag == "GroundTag") {
			audioSource.PlayOneShot (audioClip [0]);
		}
		//ユニティちゃんとぶつかったとき音を鳴らさない
		if(coll.gameObject.tag == "UnityChan2DTag"){
			GetComponent<AudioSource> ().volume = 0;
		}

}
}
