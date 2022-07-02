using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private Button button;
    public InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void StartGame()
    {
        PlayerManager.instance.playerName = playerName.text;
        SceneManager.LoadScene(0);
    }
}
