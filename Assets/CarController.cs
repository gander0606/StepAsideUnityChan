using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
	//カメラのオブジェクト
	private GameObject MainCamera;

	// Use this for initialization
	void Start ()
	{
		//カメラのオブジェクトを取得
		this.MainCamera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//車がカメラより後ろになった場合車を破棄
		if (this.transform.position.z < MainCamera.transform.position.z)
		{
			Destroy(this.gameObject);
			Debug.Log("車が消える");
		}
	}
}
