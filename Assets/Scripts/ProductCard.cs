using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProductCard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _productName;
    [SerializeField] TextMeshProUGUI _category;
    [SerializeField] TextMeshProUGUI _subCategory;
    
    public void SetProductDetails(string productName, string category, string subCategory)
    {
        _productName.text = productName;
        _category.text = category;
        _subCategory.text = subCategory;
    }
}
