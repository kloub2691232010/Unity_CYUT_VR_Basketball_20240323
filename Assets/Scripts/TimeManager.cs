using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("時間文字")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 100)]
    private float timeTotal = 60;

    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        timeTotal -= Time.deltaTime;

        textTime.text = $"Time - {timeTotal}";
    }
}
