using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class Nobarrage : MonoBehaviour
{

    private int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        var key = Observable.EveryUpdate();
        key
        .Where(_ => Input.GetKey(KeyCode.Space))
        .ThrottleFirst(TimeSpan.FromSeconds(1))
        .Subscribe(num => Debug.Log((a++).ToString())).AddTo(this);
    }

    // Update is called once per frame
}
