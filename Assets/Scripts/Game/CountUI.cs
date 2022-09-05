using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class CountUI : MonoBehaviour
{
    public Text text;
    [SerializeField]
    private Money money;

    // Start is called before the first frame update
    void Start()
    {
        money.saving
        .Subscribe(saving => UpdateCount(saving)).AddTo(this);
    }

    // Update is called once per frame
    void UpdateCount(int num)
    {
        text.text = "持ち金: " + num;
    }
}
