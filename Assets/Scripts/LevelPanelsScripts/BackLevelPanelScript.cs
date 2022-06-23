using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackLevelPanelScript : MonoBehaviour
{
    LevelsPanelScript levelsPanelScript;
    [SerializeField] GameObject ThisPanel;
    [SerializeField] Text ThisPanelText;
    [SerializeField] GameObject _player;

    private void Awake()
    {
        levelsPanelScript = FindObjectOfType<LevelsPanelScript>();
    }

    private void Update()
    {
        ThisPanelText.text = "ARE YOU SURE WANT TO BACK LEVEL " + (levelsPanelScript.levelIndex) + " ?";

    }
    public void YesButton()
    {
        levelsPanelScript.levelIndex -= 1;
        _player.transform.position = levelsPanelScript.newsPositions[levelsPanelScript.levelIndex];
        ThisPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void NoButton()
    {
        ThisPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
