using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCountTracker : MonoBehaviour
{
    //Adding Singleton instance
    public static KillCountTracker s_instance { get; private set; }

    // using the TextMeshProUGUI component
    [SerializeField] private TextMeshProUGUI killCountText; 

    // Property to track the kill count
    public int KillCount { get; private set; }

    void Awake()
    {
        // Checking if an instance already exists
        if (s_instance == null)
        {
            // If not, set instance to this
            s_instance = this;
            // Also to keep this object alive when loading new scenes
            DontDestroyOnLoad(gameObject);
        }
        else if (s_instance != this)
        {
            // If an instance already exists and it's not this one, destroy this one
            Destroy(gameObject);
        }
    }

    // Method to track the kill count
    public void KillCounter()
    {
        KillCount++;
        // Optionally, update the UI or other game elements here
        UpdateKillCountUI();
    }

    // Placeholder for method to update the UI
    private void UpdateKillCountUI()
    {
        // Implement the UI update logic here
        // For example: killCountText.text = "Kills: " + KillCount.ToString();
    }
}

