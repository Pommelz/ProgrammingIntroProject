using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableTest : MonoBehaviour
{
    float floatNumber;
    double biggerFloatingNumber;
    int wholeNumber;
    bool isTrue;
    string charArray;
    int[] intArray;

    //Text myText;
    //Image[] myImages;

    // Start is called before the first frame update
    void Start()
    {
        var temp1 = 1.5f;
        var temp2 = 1.25;
        var temp3 = 5;
        // var temp4 = true;
        //var temp5 = "Hallo Welt!";
        var temp6 = new int[2];
        temp6[0] = 1;
        temp6[1] = 2;

        //
        floatNumber = 0;
        biggerFloatingNumber = 0;
        wholeNumber = 0;
        isTrue = !isTrue;
        charArray = "";
        intArray = null;
    }

    public void PrintProgress()
    {
        Debug.Log("fliessZahl = " + floatNumber.ToString());
        Debug.Log("auchFliessZahl = " + biggerFloatingNumber.ToString());
        Debug.Log("ganzZahl = " + wholeNumber.ToString());
        Debug.Log(charArray);
        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
    }
}
