using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("時間文字")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 100)]
    private float timeTotal = 60;
    [SerializeField, Header("遊戲結束")]
    private GameObject canvasFinalobject;
    [SerializeField, Header("檢查區域")]
    private GameObject scoreManagerobject;
    [SerializeField, Header("按鈕生成籃球")]
    private Button btnSpawn;


    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        timeTotal -= Time.deltaTime;

        timeTotal = Mathf.Clamp(timeTotal, 0, 100);

        textTime.text = $"Time - {timeTotal.ToString("F1")}";

        if (timeTotal == 0) GameOver();
    }

    private void GameOver()
    {
        canvasFinalobject.SetActive(true);
        scoreManagerobject.SetActive(false);
        btnSpawn.interactable = false;
    }
}
