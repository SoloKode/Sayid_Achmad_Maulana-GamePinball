using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;
    void Start() => DefaultScore();

    public void AddScore(float addition)
    {
        // tambah skor berdasarkan parameter
        score += addition;
        Debug.Log(score);
    }
    public void SubtractScore(float subtracted){
        score -= subtracted;
        Debug.Log(score);
    }
    public void ResetScore() => score = 0;
    private void DefaultScore() => score = 6;
}