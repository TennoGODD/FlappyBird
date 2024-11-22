using TMPro;
using System;
using UnityEngine;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textscore;
    public TextMeshProUGUI scoreAfterDie;
    public TextMeshProUGUI bestScore;

    private void Update() {
        scoreAfterDie.text =textscore.text.Substring(7);
    }
}