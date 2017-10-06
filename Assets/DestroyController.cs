using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;


	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんが通り過ぎたオブジェクトを１秒後に削除
		if (this.unitychan.transform.position.z > this.transform.position.z) {
			Destroy (gameObject, 1);
			Debug.Log ("destroy");
		}

	}
}
