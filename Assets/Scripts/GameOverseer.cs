using UnityEngine;

public class GameOverseer : MonoBehaviour {
    #region static variables
    private static GameOverseer instance;

    public static GameOverseer Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameOverseer>();
            }
            return instance;
        }
    }
    #endregion static variables

    #region main variables 
    public PlayerStats player;
    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        instance = this;
        if (!player) player = GameObject.FindObjectOfType<PlayerStats>();
    }
    #endregion monobehaviour methods
}
