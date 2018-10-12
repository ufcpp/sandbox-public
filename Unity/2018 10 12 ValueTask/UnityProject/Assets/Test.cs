using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] Button _button1;
    [SerializeField] Button _button2;
    [SerializeField] Button _button3;
    [SerializeField] Button _button4;
    [SerializeField] Button _button5;
    [SerializeField] Button _button6;
    [SerializeField] Text _text;

    void Start()
    {
        _button1.onClick.AddListener(OnButton1); 
        _button2.onClick.AddListener(OnButton2); 
        _button3.onClick.AddListener(OnButton3); 
        _button4.onClick.AddListener(OnButton4); 
        _button5.onClick.AddListener(OnButton5);
        _button6.onClick.AddListener(OnButton6);
    }

    private async void OnButton1()
    {
        await ClassLibrary1.Class1.M1();
        _text.text = "1";
    }

    private async void OnButton2()
    {
        await ClassLibrary1.Class1.M2();
        _text.text = "2";
    }

    private async void OnButton3()
    {
        await ClassLibrary1.Class1.M3();
        _text.text = "3";
    }

    private async void OnButton4()
    {
        await ClassLibrary1.Class1.M4();
        _text.text = "4";
    }

    private async void OnButton5()
    {
        await ClassLibrary1.Class1.M5();
        _text.text = "5";
    }

    private async void OnButton6()
    {
        await ClassLibrary1.Class1.M6();
        _text.text = "6";
    }
}
