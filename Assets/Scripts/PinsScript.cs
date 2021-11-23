using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinsScript : MonoBehaviour
{
    [SerializeField] Text pin1;
    [SerializeField] Text pin2;
    [SerializeField] Text pin3;
    [SerializeField] Text TimerText;
    public int count = 60;
    float currentTime = 0;
    float time;
    int timer = 0;
    [SerializeField] GameObject lose;
    [SerializeField] GameObject win;
    bool endGame = false;
    int pin1Text;
    int pin2Text;
    int pin3Text;

    void Start()
    {
        time = 0;
        pin1Text = 12;
        pin2Text = 11;
        pin3Text = 10;
        pin1.text = pin1Text.ToString();
        pin2.text = pin2Text.ToString();
        pin3.text = pin3Text.ToString();
        TimerText.text = count.ToString();
    }

    void Update()
    {
        time += Time.deltaTime;
        currentTime = Mathf.Round(time);
        timer = count - System.Convert.ToInt32(currentTime);
        if (endGame == false)
        {
            TimerText.text = timer.ToString();
        }
        if (TimerText.text == "0")
        {
            lose.SetActive(true);
            endGame = true;
        }
        if (pin1Text == 3 && pin2Text == 3 && pin3Text == 3)
        {
            win.SetActive(true);
            endGame = true;
        }
    }


    public void AgainGame()
    {
        endGame = false;
        Start();
        Update();
        lose.SetActive(false);
        win.SetActive(false);
    }

    public void ClickTool1()
    {
        pin1Text -= 1;
        pin2Text -= 2;
        pin3Text -= 3;
        pin1.text = pin1Text.ToString();
        pin2.text = pin2Text.ToString();
        pin3.text = pin3Text.ToString();
    }

    public void ClickTool2()
    {
        pin1Text -= 1;
        pin2Text -= 0;
        pin3Text += 1;
        pin1.text = pin1Text.ToString();
        pin2.text = pin2Text.ToString();
        pin3.text = pin3Text.ToString();
    }

    public void ClickTool3()
    {
        pin1Text -= 0;
        pin2Text += 1;
        pin3Text += 2;
        pin1.text = pin1Text.ToString();
        pin2.text = pin2Text.ToString();
        pin3.text = pin3Text.ToString();
    }
}
