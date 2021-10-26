using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Store : MonoBehaviour, IStore
{
    [SerializeField] float wallet = 1000f;
    [SerializeField] TextMeshProUGUI walletText;
    [SerializeField] GameObject[] items;
    [SerializeField] int amount = 10;
    [SerializeField] List<GameObject> cart;

    // Start is called before the first frame update
    void Start()
    {
        UpdateWallet(0);
        for (int i = 0; i < amount; i++)
        {
            Instantiate(items[Random.Range(0, items.Length)], transform);
        }
    }

    public void UpdateWallet(float amount)
    {
        wallet += amount;
        walletText.text = $"WALLET: ${wallet.ToString()}";
    }

    public void AddToCart(GameObject item)
    {
        cart.Add(item);
    }

    public void RemoveFromCart(GameObject item)
    {
        cart.Remove(item);
    }

    public void Buy()
    {
        var totalPrice = 0f;

        foreach (var item in cart)
        {
            totalPrice -= item.GetComponentInChildren<StoreItem>().GetPrice();
        }

        UpdateWallet(totalPrice);
    }

    public void Sell()
    {
        throw new System.NotImplementedException();
    }
}
