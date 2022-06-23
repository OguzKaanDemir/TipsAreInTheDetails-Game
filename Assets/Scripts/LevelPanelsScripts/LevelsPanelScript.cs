using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsPanelScript : MonoBehaviour
{
    [SerializeField] InputField[] _inputs;
    [SerializeField] GameObject[] _panels;
    [SerializeField] GameObject _LevelloadingPanel;
    [SerializeField] public int levelIndex;
    [SerializeField] public Vector3[] newsPositions;
    [SerializeField] GameObject _player;

    public void Numpad(string value)
    {
        _inputs[levelIndex].text += value;
    }
    public void CheckCorrectAnswer(string answer)
    {
        if (_inputs[levelIndex].text == answer)
        {
            Time.timeScale = 0f;
            _panels[levelIndex].SetActive(false);
            _LevelloadingPanel.SetActive(true);
            _player.GetComponent<OD_Mover>().speed = 0;
            levelIndex++;
            StartCoroutine(_LevelloadingPanel.GetComponent<LevelLoadingPanelScript>().waitForLoadingPanel(newsPositions[levelIndex]));
        }
        else
        {
            _inputs[levelIndex].text = null;
        }
    }

    public void ExitPanel()                              
    {
        _panels[levelIndex].SetActive(false);
        _inputs[levelIndex].text = null;
        Time.timeScale = 1f;
    }

    
}
