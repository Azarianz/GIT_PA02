using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveScore : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SavedScore", GameManager.Score);
        HighScoreText.text = "Score: " + PlayerPrefs.GetInt("SavedScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
