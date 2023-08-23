using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopUI : MonoBehaviour
{
    public static ShopUI instance;
    enum Activity
    {
        BUY,
        SELL
    }
    Activity currentActivity;
    [SerializeField] GameObject shopContainer;
    [SerializeField] GameObject activityBox;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform content;
    [SerializeField] Selectable firstSelected;
    Selectable firstItemSelectable;
    Shop activeShop;
    private void Awake()
    {
        instance = this;
    }
    public void Open(Shop shop)
    {
        activeShop = shop;
        activityBox.SetActive(true);
        firstSelected.Select();
    }
    public void Buy()
    {
        currentActivity = Activity.BUY;
        OpenShop(activeShop.GetItems());
    }
    public void Sell()
    {
        currentActivity = Activity.SELL;
        OpenShop(Inventory.instance.GetItems());
    }
    void OpenShop(List<Item> items)
    {

        shopContainer.SetActive(true);
        for (int i = 0; i < items.Count; i++)
        {

            ItemUI ui = Instantiate(itemPrefab, content).GetComponent<ItemUI>();
            Button itemBttn = ui.gameObject.GetComponent<Button>();
            if (i == 0)
            {
                firstItemSelectable = itemBttn;
                firstItemSelectable.Select();
            }
            ui.SetItem(items[i]);
        }
    }

    public void Close()
    {
        shopContainer.SetActive(false);
        foreach (Transform t in content)
        {
            Destroy(t.gameObject);
        }
    }
}
