using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public GameObject slider;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;
    public GameObject img8;
    public GameObject img9;
    float yValue1;
    float yValue2;
    float yValue3;
    float yValue4;
    float yValue5;
    float yValue6;
    float yValue7;
    float yValue8;
    float yValue9;

    public void changeSizeX()
    {
        yValue1 = 4;
        yValue2 = 4;
        yValue3 = 4;
        yValue4 = 4;
        yValue5 = 4;
        yValue6 = 4;
        yValue7 = 4;
        yValue8 = 4;
        yValue9 = 4;
        float value = slider.GetComponent<Slider>().value;
        img1.transform.localScale = new Vector2(1F * value, yValue1);
        img2.transform.localScale = new Vector2(1F * value, yValue2);
        img3.transform.localScale = new Vector2(1F * value, yValue3);
        img4.transform.localScale = new Vector2(1F * value, yValue4);
        img5.transform.localScale = new Vector2(1F * value, yValue5);
        img6.transform.localScale = new Vector2(1F * value, yValue6);
        img7.transform.localScale = new Vector2(1F * value, yValue7);
        img8.transform.localScale = new Vector2(1F * value, yValue8);
        img9.transform.localScale = new Vector2(1F * value, yValue9);
    }
}
