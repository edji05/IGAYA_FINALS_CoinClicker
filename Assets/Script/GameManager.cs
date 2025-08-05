using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TMP_Text countText;
    private int count = 0;
    private float passiveIncome = 0f;

    void Start()
    {
        InvokeRepeating("GeneratePassiveIncome", 1f, 1f);
        UpdateUI();
    }

    public void OnCoinClicked()
    {
        count++;
        UpdateUI();
    }

    public bool PurchaseAction(int cost)
    {
        if (count >= cost)
        {
            count -= cost;
            UpdateUI();
            return true;
        }
        return false;
    }

    void GeneratePassiveIncome()
    {
        count += Mathf.RoundToInt(passiveIncome);
        UpdateUI();
    }

    public void AddPassiveIncome(float income)
    {
        passiveIncome += income;
    }

    void UpdateUI()
    {
        countText.text = "Count: " + count;
    }
}