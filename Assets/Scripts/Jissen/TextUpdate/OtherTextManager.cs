using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherTextManager : MonoBehaviour
{
    public Text UI;

    public void UpdateCounter(int num)
    {
        UI.text = "count: " + num;
    }
}
