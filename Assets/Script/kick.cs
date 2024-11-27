using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    BoxCollider boxCol;
    private int rotatiomCount;

    private Vector3 _localRotation = Vector3.zero;

    void Start()
    {
        boxCol = GetComponent<BoxCollider>();
        rotatiomCount = 0;
        _localRotation = transform.localEulerAngles;
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            //1フレーム毎に-1度ずつ回転する
            _localRotation.z -= 1;
            _localRotation.z -= 1;

            if(Input.GetKey("z"))
            {
                //さらに回転する速度を上げる
                _localRotation.z -= 2;
            }
            //-179度になったら0度に角度を戻す
            if(_localRotation.z < -179)
            {
                _localRotation.z = 0;
            }
            transform.localEulerAngles = _localRotation;
        }
    }
}
