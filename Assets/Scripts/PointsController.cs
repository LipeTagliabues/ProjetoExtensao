using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using System;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;

    void Start()
    {
        pointsText.text = "0";
    }

    void Update()
    {
        
    }

    public void ManagePoints(bool isDumpsterBlue)
    {
        int points;

        if (isDumpsterBlue)
        {
            points = Convert.ToInt32(pointsText.text) + 1;
            pointsText.text = points.ToString();
        }
        else
        {
            points = Convert.ToInt32(pointsText.text) - 1;
            pointsText.text = points.ToString();
        }
    }

}
