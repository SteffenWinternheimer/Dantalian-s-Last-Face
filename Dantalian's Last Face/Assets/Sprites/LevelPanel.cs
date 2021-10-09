using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPanel : MonoBehaviour
{
    public GameObject levelPanel;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            levelPanel.SetActive(true);
        }
        else
        {
            levelPanel.SetActive(false);
        }
    }
    public void OpenLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
