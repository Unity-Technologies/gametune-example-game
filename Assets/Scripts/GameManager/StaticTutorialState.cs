using System.Collections;
using UnityEngine;

public class StaticTutorialState : AState
{
    public override void Enter(AState from)
    {
        gameObject.SetActive(true);
        StartCoroutine(StartGame());
    }

    public override void Exit(AState to) {}

    public override void Tick() {}

    public override string GetName()
    {
        return "StaticTutorial";
    }

    private IEnumerator StartGame()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
        PlayerData.instance.tutorialDone = true;
        PlayerData.instance.Save();
        PlayerData.instance.tutorialAnswer.Use();
        manager.SwitchState("Game");
    }
}
