using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PushUpCount : MonoBehaviour
{

    public ReactiveProperty<int> num = new ReactiveProperty<int>(0);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            num.Value++;
        }
    }
}
