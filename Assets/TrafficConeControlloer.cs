using UnityEngine;
using System.Collections;

public class TrafficConeControlloer : MonoBehaviour
{
	//カメラのオブジェクト
	private GameObject MainCamera;

	// Use this for initialization
	void Start()
	{
		//カメラのオブジェクトを取得
		this.MainCamera = GameObject.Find("Main Camera");
	}

	// Update is called once per frame
	void Update()
	{
		//コーンがカメラより後ろになった場合コーンを破棄
		if (this.transform.position.z < MainCamera.transform.position.z)
		{
			Destroy(this.gameObject);
			Debug.Log("コーンが消える");
		}
	}
}

