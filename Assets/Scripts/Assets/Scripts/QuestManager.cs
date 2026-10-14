
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public string questName = "Первая прогулка";
    public int requiredDistance = 20;

    private int currentDistance = 0;

    public void AddProgress(int amount)
    {
        currentDistance += amount;

        if (currentDistance >= requiredDistance)
        {
            Debug.Log("Задание выполнено: " + questName);
        }
    }
}
