using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class AddMoney : MonoBehaviour
{
    [SerializeField]
    private Money money;
    [SerializeField]
    private Button button;

    // Start is called before the first frame update
    void Start()
    {  
        int a = 0;
        button.onClick.AsObservable()
        .ThrottleFirst(TimeSpan.FromSeconds(0.5f))
        .Subscribe(_ => money.GetMoney()).AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
