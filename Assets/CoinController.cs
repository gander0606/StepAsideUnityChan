using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{
  
    //カメラのオブジェクト
    private GameObject MainCamera;

    // Use this for initialization
    void Start()
    {
        //カメラのオブジェクトを取得
        this.MainCamera = GameObject.Find("Main Camera");

        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);

        //コインがカメラより後ろになった場合コインを破棄
        if (this.transform.position.z　< MainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
            Debug.Log("コインが消える");
        }

    }
}