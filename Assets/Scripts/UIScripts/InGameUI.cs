using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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
    [Header("UI Screens")]
    public PauseMenu pauseMenu;
    public RectTransform GameHUD;


    [Header("Player Stats UI")]
    public Slider healthBarSlider;

    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateHealth();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Start") && !pauseMenu.gameObject.activeSelf)
        {
            pauseMenu.gameObject.SetActive(true);
        }
    }
    #endregion monobehaviour methods

    /// <summary>
    /// This method should be called any time a player receives or takes damage
    /// </summary>
    public void UpdateHealth()
    {
        healthBarSlider.value = GameOverseer.Instance.player.currentHealth / GameOverseer.Instance.player.maxHealth;
    }

}
