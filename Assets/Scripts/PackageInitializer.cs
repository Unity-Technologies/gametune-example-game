using UnityEngine;
using UnityEngine.Advertisements;

public class PackageInitializer : MonoBehaviour
{
    public string iOSGameId;
    public string androidGameId;

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
    }
}
