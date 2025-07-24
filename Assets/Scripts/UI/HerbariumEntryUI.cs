using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HerbariumEntryUI : MonoBehaviour
{
    public Image    herb_image_;
    public TMP_Text herb_number_;
    public TMP_Text herb_usecase00_;
    public TMP_Text herb_usecase01_;
    public TMP_Text herb_usecase02_;
    public TMP_Text herb_main_;

    public void SetData(HerbariumInformation med)
    {
        herb_image_.sprite          = med.herb_image;
        herb_number_.text           = med.herb_number;
        herb_main_.text             = med.herb_main;
        herb_usecase00_.text        = med.herb_usecase00;
        herb_usecase01_.text        = med.herb_usecase01;
        herb_usecase02_.text        = med.herb_usecase02;

    }
}
