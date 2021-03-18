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

    public void changeSizeX()
    {
        float value = slider.GetComponent<Slider>().value;
        img1.transform.localScale = new Vector2(1F * value, value) ;
        img2.transform.localScale = new Vector2(1F * value, value);
        img3.transform.localScale = new Vector2(1F * value, value);
        img4.transform.localScale = new Vector2(1F * value, value);
        img5.transform.localScale = new Vector2(1F * value, value);
        img6.transform.localScale = new Vector2(1F * value, value);
        img7.transform.localScale = new Vector2(1F * value, value);
        img8.transform.localScale = new Vector2(1F * value, value);
        img9.transform.localScale = new Vector2(1F * value, value);
    }
}
