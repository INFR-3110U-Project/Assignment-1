using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCountTracker : MonoBehaviour
{
    // Adding Singleton instance
    public static KillCountTracker s_instance { get; private set; }
    // Property to track the kill count
    public int KillCount { get; private set; }

    // Using the TextMeshProUGUI component
    [SerializeField] private TextMeshProUGUI killCountText; 


    void Awake()
    {
        // Checking if an instance already exists
        if (s_instance == null)
        {
            // If not, set instance to this
            s_instance = this;
            // Also to not always destroy object when loading new scenes
            // but its optional
            DontDestroyOnLoad(gameObject);
        }
        else if (s_instance != this)
        {
            // If an instance already exists and it's not 'this' one, destroy this one
            Destroy(gameObject);
        }
    }

    // Adding a method to track the kill count
    public void KillCounter()
    {
        KillCount++;
        UpdateKillCountUI();
    }

    // Adding a method to update the UI
    private void UpdateKillCountUI()
    {
        if (killCountText != null)
        {
            killCountText.text = "Kills: " + KillCount.ToString();
        }
    }
}

