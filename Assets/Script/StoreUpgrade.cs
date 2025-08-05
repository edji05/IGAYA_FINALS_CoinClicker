using TMPro;
using UnityEngine;

public class StoreUpgrade : MonoBehaviour
{
    [Header("Components")]
    public TMP_Text priceText;
    public TMP_Text incomeInfoText;

    public int startPrice = 15;
    public float upgradePriceMultiplier = 1.5f;
    public float cookiesPerUpgrade = 0.1f;

    private int level = 0;

    void Start()
    {
        UpdateUI();
    }

    public void ClickAction()
    {
        var gameManager = FindObjectOfType<NewMonoBehaviourScript>();
        int price = CalculatePrice();

        if (gameManager.PurchaseAction(price))
        {
            level++;
            gameManager.AddPassiveIncome(cookiesPerUpgrade);
            UpdateUI();
        }
    }

    int CalculatePrice()
    {
        return Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier, level));
    }

    void UpdateUI()
    {
        priceText.text = "Cost: " + CalculatePrice();
        incomeInfoText.text = level + " x " + cookiesPerUpgrade + "/s";
    }
}