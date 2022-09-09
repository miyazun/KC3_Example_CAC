using UnityEngine;
using UniRx;

public class Money : MonoBehaviour
{
    public ReactiveProperty<int> saving = new ReactiveProperty<int>(0);
    private int salary;

    // Start is called before the first frame update
    void Start()
    {
        salary = 1;
    }

    public void GetMoney()
    {
        saving.Value += salary;
    }

    public void UpSalary(int num)
    {
        salary += num;
    }

    public void Decrease(int num)
    {
        saving.Value -= num;
    }
}
