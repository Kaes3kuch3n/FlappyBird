using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject infoText;
    public Text score;

    private void Update()
    {
        if (GameManager.GameIsRunning && infoText.activeSelf == true)
            infoText.SetActive(false);

        score.text = GameManager.Score.ToString();
    }
}
