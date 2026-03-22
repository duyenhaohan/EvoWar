using Fusion;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NetworkManager : MonoBehaviour
{
    private NetworkRunner runner;

    public async void StartHost()
    {
        runner = gameObject.AddComponent<NetworkRunner>();

        await runner.StartGame(new StartGameArgs()
        {
            GameMode = GameMode.Host,
            SessionName = "Room1",
            Scene = SceneRef.FromIndex(SceneManager.GetActiveScene().buildIndex),
            SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
        });
    }

    public async void JoinGame()
    {
        runner = gameObject.AddComponent<NetworkRunner>();

        await runner.StartGame(new StartGameArgs()
        {
            GameMode = GameMode.Client,
            SessionName = "Room1",
            SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
        });
    }
}