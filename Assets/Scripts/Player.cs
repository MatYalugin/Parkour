using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int mainMenuLevel;
    public GameObject deathMenu;
    public GameObject congratulationMenu;
    public Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Lava"))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            deathMenu.SetActive(true);
            animator.Play("FirstPersonLookOff");
        }
        if (collision.transform.tag.Equals("Portal"))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            congratulationMenu.SetActive(true);
            animator.Play("FirstPersonLookOff");
        }
    }
    public void goToMain()
    {
        if (Input.GetKey(KeyCode.Escape) && Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(mainMenuLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
       goToMain();
    }
}
