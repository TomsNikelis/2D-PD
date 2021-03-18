using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public GameObject sliderX;
    public GameObject sliderY;
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
        float valueX = sliderX.GetComponent<Slider>().value;
        float valueY = sliderY.GetComponent<Slider>().value;
        img1.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img2.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img3.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img4.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img5.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img6.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img7.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img8.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img9.transform.localScale = new Vector2(1F * valueX, 1F * valueY);

    }
    public void changeSizeY()
    {
        float valueX = sliderX.GetComponent<Slider>().value;
        float valueY = sliderY.GetComponent<Slider>().value;
        img1.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img2.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img3.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img4.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img5.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img6.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img7.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img8.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
        img9.transform.localScale = new Vector2(1F * valueX, 1F * valueY);
    }
}
