using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour {
    public bool OnStartSwitchToMain = true;
	public GameObject MainMenu;
	public GameObject SettingsMenu;

	public void Awake()
	{
        if (OnStartSwitchToMain)
        {
            EnableMainMenu();
            DisableSettingsMenu();
        }
	}

	public void StartGame()
	{
		SceneManager.LoadScene("Main", LoadSceneMode.Single);
		// SceneManager.UnloadSceneAsync("UI");
		// MainMenu.SetActive(false);
		Debug.Log(MainMenu.activeInHierarchy);
	}
	public void EnableMainMenu()
	{
		MainMenu.SetActive(true);
	}
	public void DisableSettingsMenu()
	{
		SettingsMenu.SetActive(false);
	}
	public void EnableSettingsMenu()
	{
		SettingsMenu.SetActive(true);
	}
}
