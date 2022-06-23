using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoadingPanelScript : MonoBehaviour
{
    [SerializeField] GameObject ThisPanel;
    [SerializeField] GameObject _player;
    public IEnumerator waitForLoadingPanel(Vector3 newPos)
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(Random.Range(0.7f, 1.5f));
        ThisPanel.SetActive(false);
        _player.transform.position = newPos;
        _player.GetComponent<OD_Mover>().speed = 3.2f;
    }
}
