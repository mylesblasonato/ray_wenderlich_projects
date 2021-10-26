using UnityEngine;

public interface IStore
{
    public void UpdateWallet(float amount);
    public void AddToCart(GameObject item);
    public void RemoveFromCart(GameObject item);
    public void Buy();
    public void Sell();
}
