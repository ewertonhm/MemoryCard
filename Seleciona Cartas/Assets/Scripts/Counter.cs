using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    [SerializeField] int playTime;
    [SerializeField] string nextView;
    [SerializeField] float timeLeft;
    
    [SerializeField] GameObject counterDisplayText;

    private void timeOver()
    {
        SceneManager.LoadScene(nextView);
    }

    public string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time - 60 * minutes;
        int milliseconds = (int)(1000 * (time - minutes * 60 - seconds));
        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    public void changeScene()
    {
        GameConfigs.instance.adicionarTempoRestante((int)this.timeLeft);
        SceneManager.LoadScene(nextView);
    }

    // Start is called before the first frame update
    void Start()
    {
        playTime = GameConfigs.instance.getGameTime();
        timeLeft = (float)playTime;
        counterDisplayText.GetComponent<TextMeshProUGUI>().text = playTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        counterDisplayText.GetComponent<TextMeshProUGUI>().text = FormatTime(timeLeft);
        if (timeLeft <= 0)
        {
            timeOver();
        }
    }
}
