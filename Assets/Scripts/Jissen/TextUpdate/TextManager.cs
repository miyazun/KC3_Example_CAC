using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TextManager : MonoBehaviour
{
    public Text UI;
    public PushUpCount counter;

    // Start is called before the first frame update
    void Start()
    {
        counter.num
        .Subscribe(num => UpdateCounter(num));
    }

    // Update is called once per frame
    private void UpdateCounter(int num)
    {
        UI.text = "count: " + num;
    }
}
