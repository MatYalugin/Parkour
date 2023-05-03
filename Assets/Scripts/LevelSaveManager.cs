using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSaveManager : MonoBehaviour
{
    public bool savingLevel = true;
    public Text loadLevelText;
    public Button continueButton;

    private int loadLevel;
    public int levelNumber;
    // Start is called before the first frame update
    void Start()
    {
        if(savingLevel == true)
        {
            PlayerPrefs.SetInt("lastLevel", levelNumber);
        }
        if (savingLevel == false)
        {
            loadLevel = PlayerPrefs.GetInt("lastLevel");
            loadLevelText.text = "(Level " + loadLevel + ")";
            if(loadLevel == 0)
            {
                loadLevelText.text = "(no level started)";
                continueButton.interactable = false;
            }
        }
    }

    public void loadLastLevel()
    {
        if (loadLevel == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (loadLevel == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (loadLevel == 3)
        {
            SceneManager.LoadScene(3);
        }
        if (loadLevel == 4)
        {
            SceneManager.LoadScene(4);
        }
        if (loadLevel == 5)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void clearStats()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
