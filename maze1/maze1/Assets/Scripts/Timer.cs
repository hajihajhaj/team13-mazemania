using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Add this to enable scene loading

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] TextMeshProUGUI countdownText2;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        // Update both countdown texts
        countdownText.text = currentTime.ToString("0");
        countdownText2.text = currentTime.ToString("0");

        // Check if the time has run out
        if (currentTime <= 0)
        {
            currentTime = 0;
            LoadLoserScreen(); // Load the loser screen when the timer reaches zero
        }
    }

    void LoadLoserScreen()
    {
        SceneManager.LoadScene("loserScreen"); // Replace with the actual name of your loser scene
    }
}
