using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class OtherPushUpCounter : MonoBehaviour
{

    public int num = 0;
    public OtherTextManager UI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            num++;
            UI.UpdateCounter(num);
        }
    }
}
