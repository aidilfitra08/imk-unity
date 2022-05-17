using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{
    private Controls _controls;
    public void ExitGame(){
        Application.Quit();
    }

    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

	private void Awake()
    {
        _controls = new Controls();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
