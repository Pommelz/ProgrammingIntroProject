using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    [SerializeField] int number1 = 1;
    [SerializeField] int number2 = 3;


    // Start is called before the first frame update
    void Start()
    {
        AddNumbers(number1, number2);
        SubtractNumbers(number1, number2);
    }

    public void SubtractNumbers(int i, int j)
    {
        int summary = i - j;
        Debug.Log(summary);
    }

    public void AddNumbers(int i, int j)
    {
        int summary = i + j;
        Debug.Log(summary);
    }
}
