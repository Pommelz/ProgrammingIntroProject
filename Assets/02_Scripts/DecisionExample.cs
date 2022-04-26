using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecisionExample : MonoBehaviour
{
    [SerializeField] int pointsForApple = 10;
    [SerializeField] int pointsForPear = 20;
    [SerializeField] int pointsForCherry = 30;

    [SerializeField] Text pointsTxt;
    int points;

    public void PressedButton(Transform button)
    {
        // Get name of the pressed button in hierarchy
        string name = button.gameObject.name;

        switch (name)
        {
            case "Apple":
                points += pointsForApple;
                break;
            case "Pear":
                points += pointsForPear;
                break;
            case "Cherry":
                points += pointsForCherry;
                break;
        }

        //is the same as:
            //if (name == "Apple")
            //{
            //    points += pointsForApple;
            //}
            //if (name == "Pear")
            //{
            //    points += pointsForPear;
            //}
            //if (name == "Cherry")
            //{
            //    points += pointsForCherry;
            //}

        // Update points text
        pointsTxt.text = points.ToString();
    }
}