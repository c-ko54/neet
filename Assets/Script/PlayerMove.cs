using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //移動値を設定する                                  
   private float speed = 0.05f;
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            //左キーを押すと-ｘ方向に1フレーム毎にスピード値分移動する
            position.x -= speed;
        }
        else if (Input.GetKey("right"))
        {
            //右キーを押すとｘ方向に1フレーム毎にスピード値分移動する
            position.x += speed;
        }
        else if (Input.GetKey("up"))
        {
            //上キーを押すとｙ方向に1フレーム毎にスピード値分移動する
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            //下キーを押すと-ｙ方向に1フレーム毎にスピード値分移動する
            position.y -= speed;
        }

        //オブジェクトの位置に移動した値を代入する
        transform.position = position;
    }
}
