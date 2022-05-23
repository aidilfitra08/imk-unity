using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArUI : MonoBehaviour
{
    private Controls _controls;
    // Start is called before the first frame update
        private void Awake()
    {
        _controls = new Controls();
    }

    private void OnEnable()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        _controls.Enable();
    }

    private void OnDisable()
    {
        // Cursor.lockState = CursorLockMode.None;
        _controls.Disable();
    }
    // public void Start()
    // {
        
    // }

    // Update is called once per frame
    public void Update()
    {
        if (_controls.Player.Pause.IsPressed()){

            BackMenu("MenuScene");
        }
    }

    public void BackMenu(string menuScene)
    {

        SceneManager.LoadScene(menuScene);
    }
}
