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

    private int savedLevel;
    private int loadLevel;
    // Start is called before the first frame update
    void Start()
    {
        if (savingLevel == true)
        {
            savedLevel = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("lastLevel", savedLevel);
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
        SceneManager.LoadScene(loadLevel);
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
