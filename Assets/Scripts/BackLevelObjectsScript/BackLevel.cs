using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLevel : MonoBehaviour
{
    [SerializeField] GameObject BackLevelPanel;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BackLevelPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
