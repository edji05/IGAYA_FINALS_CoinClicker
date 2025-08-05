using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private NewMonoBehaviourScript gameManager;
    private int clickValue = 1;

    void Start()
    {
        gameManager = FindObjectOfType<NewMonoBehaviourScript>();
    }

    public void OnClick()
    {
        for (int i = 0; i < clickValue; i++)
        {
            gameManager.OnCoinClicked();
        }
    }

    public void IncreaseClickValue(int amount)
    {
        clickValue += amount;
    }
}