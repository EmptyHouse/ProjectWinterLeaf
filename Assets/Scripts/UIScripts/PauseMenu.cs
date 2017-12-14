using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    #region main variables
    public Transform pauseScreen;
    #endregion main variables


    #region monobehaviour methods
    private void Awake()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }
    #endregion monobehaviour methods


    #region option events
    public void OnResumeButtonPressed()
    {

    }

    public void OnExitGamePressed()
    {

    }

    #endregion option events
}
