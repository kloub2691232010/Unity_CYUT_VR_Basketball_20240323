﻿using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    [SerializeField, Header("分數文字")]
    private TMP_Text textScore;
    [SerializeField, Header("音效來源")]
    private AudioSource aud;
    [SerializeField, Header("進籃音效")]
    private AudioClip soundBasketball;

    private string basketballName = "籃球";
    private int score;

    
    private void OnTriggerEnter(Collider other)
    {
       //print(other.name);

       //如果 進入的物件名稱 包含 籃球
       //就得兩分
       if (other.name.Contains(basketballName))
        {
            score += 2;
            //print($"<color=#f93>分數:{score}</color>");
            textScore.text = $"SCORE - {score}";

            aud.PlayOneShot(soundBasketball);
        }
    }
}
