using UniRx;
using UnityEngine;

namespace Sample
{
    public class Sample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var subject = new Subject<int>();  //observer

            subject
            .Subscribe(num => Debug.Log(num.ToString())).AddTo(this);  //メッセージを送る presenter

            subject.OnNext(1); //メッセージを受け取る
            subject.OnNext(2);
            subject.OnNext(3);
        }

    }
}
