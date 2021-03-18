using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImages : MonoBehaviour
{
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject body1;
    public GameObject body2;
    public GameObject body3;
    public GameObject legs1;
    public GameObject legs2;
    public GameObject legs3;

    public void head1Show(bool value)
    {
        head1.SetActive(value);
    }
    public void head2Show(bool value)
    {
        head2.SetActive(value);
    }
    public void head3Show(bool value)
    {
        head3.SetActive(value);
    }
    public void body1Show(bool value)
    {
        body1.SetActive(value);
    }
    public void body2Show(bool value)
    {
        body2.SetActive(value);
    }
    public void body3Show(bool value)
    {
        body3.SetActive(value);
    }
    public void legs1Show(bool value)
    {
        legs1.SetActive(value);
    }
    public void legs2Show(bool value)
    {
        legs2.SetActive(value);
    }
    public void legs3Show(bool value)
    {
        legs3.SetActive(value);
    }
}
