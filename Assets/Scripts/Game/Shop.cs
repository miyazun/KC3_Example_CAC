using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class Shop : MonoBehaviour
{
    public Money money;
    [SerializeField]
    private Button button;
    [SerializeField]
    private int price;
    [SerializeField]
    private int plusSalary;


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AsObservable()
        .Select(num => money.saving.Value)
        .Where(num => num >= price)
        .Subscribe(_ => Bought());
    }

    // Update is called once per frame
    void Bought()
    {
        money.Decrease(price);
        money.UpSalary(plusSalary);
    }
}
