using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreItem : MonoBehaviour
{
    [SerializeField] int id = 0;
    [SerializeField] string itemName;
    [SerializeField] float price = 5f;
    [SerializeField] GameObject outline;
    [SerializeField] TextMeshProUGUI priceText;
    [SerializeField] TextMeshProUGUI nameText;

    Store store;
    bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        store = FindObjectOfType<Store>();

        nameText.text = itemName;
        priceText.text = $"${price.ToString()}";
    }

    public float GetPrice() => price;

    public void Select()
    {
        isSelected = !isSelected;
        outline.SetActive(isSelected);

        if (isSelected)
            store.AddToCart(transform.parent.gameObject);
        else
            store.RemoveFromCart(transform.parent.gameObject);
    }
}
