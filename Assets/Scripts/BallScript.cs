using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update


    int speed = 10;　// ここでボールの速さを決めれるよ！数字を上げると早くなって、下げると遅くなる！

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right") == true)　// 右矢印キーを押した時
        {
            // 右方向への移動についてのコード
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }


        //　この下に上下左キーを押したときについてのコードを書いてみよう！
    }
}
