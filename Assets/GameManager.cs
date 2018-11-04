using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsRunning;
    public static int Score;

    private void Start()
    {
        GameIsRunning = false;
        Score = 0;
    }

    private void Update()
    {
        if (!GameIsRunning && (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")))
        {
            GameIsRunning = true;
        }
    }
}
