using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ForDropdown : MonoBehaviour
{
    public TMP_Dropdown nesne;
    public Sprite[] bayraklar;
    public ForDropdown instance;
    public TextMeshProUGUI startText;


    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
        nesne.ClearOptions();

        
        List<TMP_Dropdown.OptionData> bayraklistesi = new List<TMP_Dropdown.OptionData>();

        foreach (var bayrak in bayraklar)
        {
            string bayrakIsim = bayrak.name;
            var secim = new TMP_Dropdown.OptionData(bayrakIsim, bayrak);
            bayraklistesi.Add(secim);
        }

        
        nesne.AddOptions(bayraklistesi);

        
        if (PlayerPrefs.HasKey("DropdownValue"))
        {
            nesne.value = PlayerPrefs.GetInt("DropdownValue");
        }

        
        nesne.onValueChanged.AddListener(delegate {
            SaveDropdownValue(nesne.value);
        });
        Debug.Log(PlayerPrefs.GetInt("DropdownValue"));
    }

    private void Update()
    {
       LanguageSecIntro();
    }

    public void LanguageSecIntro()
    {
        if (nesne.value == 0)
        {
            startText.text = "Start";
        }
        else if (nesne.value == 1)
        {
            startText.text = "Basla";
        }
        else if (nesne.value == 2)
        {
            startText.text = "commencer";
        }
        else if (nesne.value == 3)
        {
            startText.text = "başlamaq";
        }
        else if (nesne.value == 4)
        {
            startText.text = "Start";
        }
        else if (nesne.value == 5)
        {
            startText.text = "започнете";
        }
        else if (nesne.value == 6)
        {
            startText.text = "დაწყება";
        }
        else if (nesne.value == 7)
        {
            startText.text = "начинать";
        }
        else if (nesne.value == 8)
        {
            startText.text = "початок";
        }
        else if (nesne.value == 9)
        {
            startText.text = "begin";
        }
        else if (nesne.value == 10)
        {
            startText.text = "شروع کنید";
        }
    }

    void SaveDropdownValue(int value)
    {
        
        PlayerPrefs.SetInt("DropdownValue", value);
        PlayerPrefs.Save();
    }

}
