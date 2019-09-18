using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.GameTune;
using UnityEngine.UI;

#if UNITY_ANALYTICS
using UnityEngine.Analytics;
#endif
#if UNITY_PURCHASING
using UnityEngine.Purchasing;
#endif

public class StartButton : MonoBehaviour
{
    public Button button;
    public Text buttonText;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (!button.interactable)
        {
            button.interactable = PlayerData.instance.tutorialAnswer != null;
            if (button.interactable)
            {
                buttonText.text = "Start";
            }
        }
    }

    public void StartGame()
    {
        if (PlayerData.instance.ftueLevel == 0)
        {
            PlayerData.instance.ftueLevel = 1;
            PlayerData.instance.Save();
#if UNITY_ANALYTICS
            AnalyticsEvent.FirstInteraction("start_button_pressed");
#endif
        }

#if UNITY_PURCHASING
        var module = StandardPurchasingModule.Instance();
#endif

        if (PlayerData.instance.tutorialAnswer.Value != "static")
        {
            PlayerData.instance.tutorialAnswer.Use();
        }

        SceneManager.LoadScene("main");
    }
}
