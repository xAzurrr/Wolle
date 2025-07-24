using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class HerbariumListManager : MonoBehaviour
{
    public Transform contentParent; 
    public GameObject HerbariumInformationPanelPrefab;

    public TMP_InputField searchInputField; 

    public List<HerbariumInformation> herbariumInformations; 
    private List<GameObject> currentEntries = new List<GameObject>(); 

    void Start()
    {
        PopulateList();

       
        searchInputField.onValueChanged.AddListener(OnSearchValueChanged);
    }

    void PopulateList()
    {
        
        foreach (var entry in currentEntries)
        {
            Destroy(entry);
        }
        currentEntries.Clear();

        foreach (var information in herbariumInformations)
        {
            var item = Instantiate(HerbariumInformationPanelPrefab, contentParent);
            var ui = item.GetComponent<HerbariumEntryUI>();
            ui.SetData(information);
            currentEntries.Add(item);
        }
    }

    void OnSearchValueChanged(string searchText)
    {
        searchText = searchText.Trim();

        foreach (var entry in currentEntries)
        {
            var ui = entry.GetComponent<HerbariumEntryUI>();
            bool matches = ui.herb_number_.text.Contains(searchText);

            entry.SetActive(matches);
        }
    }
}
