using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{
    public GameObject [] englishTextFields;
    public GameObject[] russianTextFields;
    private int i = 0;
    private void Awake()
    {
        SetText(englishTextFields, false);
        SetText(russianTextFields, false);
    }
    void Update()
    {
        if (i < 5)
        {
            if(PlayerPrefs.GetString("lang") == "en")
            {
                SetText(englishTextFields, true);
                SetText(russianTextFields, false);
            }
            else
            {
                SetText(englishTextFields, false);
                SetText(russianTextFields, true);
            }

            i = i + 1;
        }
    }

    public void SetText(GameObject [] languageTextFields, bool isActive)
    {
        foreach (GameObject languageTextField in languageTextFields)
        {
            languageTextField.SetActive(isActive);
        }
    }


}
