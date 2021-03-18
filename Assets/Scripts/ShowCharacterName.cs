using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāieimportē, lai varētu strādāt ar UI elementiem
using UnityEngine.UI;

public class ShowCharacterName : MonoBehaviour
{
    string textName;
    string textAge;
    public GameObject inputFieldName;
    public GameObject inputeFieldAge;
    public GameObject displayFieldName;
    public GameObject displayFieldAge;

    public void displayName()
    {
        textName = inputFieldName.GetComponent<Text>().text;
        displayFieldName.GetComponent<Text>().text = textName;
    }
    public void displayAge()
    {
        textAge = inputeFieldAge.GetComponent<Text>().text;
        displayFieldAge.GetComponent<Text>().text = "Age: " + textAge;
    }
}