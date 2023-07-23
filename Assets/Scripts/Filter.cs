using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class Card
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string SubCategory { get; set; }
}

public class Filter : MonoBehaviour
{
    [SerializeField] TMP_Dropdown _mainDropDown;
    [SerializeField] TMP_Dropdown _subDropDown;
    [SerializeField] Transform _content;
    [SerializeField] ProductCard _productCard;
    List<Card> cardList = new List<Card>
    {
        new Card {Name = "WatchM1",Category = "Watches",SubCategory = "Men"},
        new Card {Name = "WatchM2",Category = "Watches",SubCategory = "Men"},
        new Card {Name = "WatchM3",Category = "Watches",SubCategory = "Men"},
        new Card {Name = "WatchF1",Category = "Watches",SubCategory = "Women"},
        new Card {Name = "WatchF2",Category = "Watches",SubCategory = "Women"},
        new Card {Name = "WatchF3",Category = "Watches",SubCategory = "Women"},
        new Card {Name = "WatchK1",Category = "Watches",SubCategory = "Kids"},
        new Card {Name = "WatchK2",Category = "Watches",SubCategory = "Kids"},
        new Card {Name = "WatchK3",Category = "Watches",SubCategory = "Kids"},
        new Card {Name = "ShirtM1",Category = "Clothes",SubCategory = "Men"},
        new Card {Name = "ShirtM2",Category = "Clothes",SubCategory = "Men"},
        new Card {Name = "TrouserM1",Category = "Clothes",SubCategory = "Men"},
        new Card {Name = "TrouserM1",Category = "Clothes",SubCategory = "Men"},
        new Card {Name = "TrouserF1",Category = "Clothes",SubCategory = "Women"},
        new Card {Name = "TrouserF2",Category = "Clothes",SubCategory = "Women"},
        new Card {Name = "TopF1",Category = "Clothes",SubCategory = "Women"},
        new Card {Name = "TopF2",Category = "Clothes",SubCategory = "Women"},
        new Card {Name = "TShirtK1",Category = "Clothes",SubCategory = "Kids"},
        new Card {Name = "TShirtK2",Category = "Clothes",SubCategory = "Kids"},
        new Card {Name = "JeansK1",Category = "Clothes",SubCategory = "Kids"},
        new Card {Name = "JeansK2",Category = "Clothes",SubCategory = "Kids"},
        new Card {Name = "RingM1",Category = "Jewellery",SubCategory = "Men"},
        new Card {Name = "RingM2",Category = "Jewellery",SubCategory = "Men"},
        new Card {Name = "RingM3",Category = "Jewellery",SubCategory = "Men"},
        new Card {Name = "RingF1",Category = "Jewellery",SubCategory = "Women"},
        new Card {Name = "RingF2",Category = "Jewellery",SubCategory = "Women"},
        new Card {Name = "RingF3",Category = "Jewellery",SubCategory = "Women"},
        new Card {Name = "RingK1",Category = "Jewellery",SubCategory = "Kids"},
        new Card {Name = "RingK2",Category = "Jewellery",SubCategory = "Kids"},
        new Card {Name = "RingK3",Category = "Jewellery",SubCategory = "Kids"},

    };
    // Start is called before the first frame update
    void Start()
    {
       foreach(Card card in cardList)
        {
            ProductCard prodCard = Instantiate(_productCard, _content);
            prodCard.SetProductDetails(card.Name, card.Category, card.Category);
        }
    }

    private void DisableAllCards()
    {
        int count = _content.childCount;
        for(int i = 0; i < count; i++)
        {
            _content.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void FilterProducts(string category, string subcategory)
    {
        DisableAllCards();
        foreach(Card card in cardList)
        {
            if(card.Category == category && card.SubCategory == subcategory)
            {
                int index = cardList.IndexOf(card);
                _content.GetChild(index).gameObject.SetActive(true);
            }
        }
    }

    private void EnableAllCards()
    {
        int count = _content.childCount;
        for (int i = 0; i < count; i++)
        {
            _content.GetChild(i).gameObject.SetActive(true);
        }
    }

    public void ApplyFilter()
    {
        string category = _mainDropDown.options[_mainDropDown.value].text.ToString();
        string subcategory = _subDropDown.options[_subDropDown.value].text.ToString();
        FilterProducts(category, subcategory);
    }

    public void ResetFilter()
    {
        EnableAllCards();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
