using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class IAPShop : MonoBehaviour
{
    private string pack1 = "com.fuguestategames.fslabs.pack1";
    private string pack2 = "com.fuguestategames.fslabs.pack2";

    public void OnPurchaseComplete(Product _items)
    {
        if (_items.definition.id == pack1)
        {
            Items.Instance.GivePack1();
            Debug.Log("Pack 1 purchase success");
        }

        else if (_items.definition.id == pack2)
        {
            Items.Instance.GivePack2();
            Debug.Log("Pack 2 purchase success");
        }
    }

    public void OnPurchaseFailed(Product _items, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of " + _items.definition.id + "failed due to " + reason);
    }

}
