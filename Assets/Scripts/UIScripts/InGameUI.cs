using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : MonoBehaviour {
    #region static variables
    private InGameUI instance;
    
    public InGameUI Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<InGameUI>();
            }
            return instance;
        }
    }
    #endregion static variables

    #region main variables 
    public PauseMenu pauseMenu;

    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Start") && !pauseMenu.gameObject.activeSelf)
        {
            pauseMenu.gameObject.SetActive(true);
        }
    }
    #endregion monobehaviour methods

}
