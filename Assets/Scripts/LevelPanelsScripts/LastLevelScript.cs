using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastLevelScript : MonoBehaviour
{
    [SerializeField] InputField _inputFirst;
    [SerializeField] InputField _inputSecond;
    [SerializeField] GameObject _level3panel;
    [SerializeField] GameObject _firstPanel;
    [SerializeField] GameObject _secondPanel;
    [SerializeField] GameObject _player;

    public void Numpad1(string value)
    {
        _inputFirst.text += value;
    }
    public void Numpad2(string value)
    {
        _inputSecond.text += value;
    }
    public void FirstQuestionCheckCorrectAnswer(string answer)
    {
        if (_inputFirst.text == answer)
        {
            _firstPanel.SetActive(false);
            _secondPanel.SetActive(true);
        }
        else
        {
            _inputFirst.text = null;
        }
    }

    public void SecondQuestionCheckCorrectAnswer(string answer)
    {
        if (_inputSecond.text == answer)
        {
            _secondPanel.SetActive(false);
            Time.timeScale = 1f;
            SceneManager.LoadScene("Finish");
        }
        else
        {
            _inputSecond.text = null;
        }
    }
    public void exit1()
    {
        _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - 1f);
        _level3panel.SetActive(false);
        _inputFirst.text = null;
        Time.timeScale = 1f;
    }
    public void exit2()
    {
        _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - 1f);
        _level3panel.SetActive(false);
        _inputSecond.text = null;
        Time.timeScale = 1f;
    }
}
