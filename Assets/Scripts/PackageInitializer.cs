using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.GameTune;

public class PackageInitializer : MonoBehaviour
{
    public string iOSGameId;
    public string androidGameId;
    public string unityProjectId;

    private string gameId = "";

    void Awake()
    {
#if UNITY_IOS
        gameId = iOSGameId;
#endif
#if UNITY_ANDROID
        gameId = androidGameId;
#endif
        Advertisement.Initialize(gameId);
        InitializeOptions options = new InitializeOptions();
        options.SetGdprConsent(true); // assuming a user has given a consent
        GameTune.Initialize(unityProjectId, options);
    }

    void Start()
    {
        Question tutorialQuestion = GameTune.CreateQuestion(
            "tutorial",
            new string[] { "playable", "static", "off" },
            PlayerData.instance.SetTutorial
        );

        GameTune.AskQuestions(tutorialQuestion);
    }
}
