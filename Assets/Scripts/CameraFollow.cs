using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    #region main variables
    [Tooltip("A reference to the player to follow. This is the most important unit to follow when calculating camera position")]
    private Transform playerTransform;
    [Tooltip("This list will hold enemy Transforms that the camera shold focus. Typically when in action. Can also be used to focus on important items")]
    private List<Transform> secondaryTargetList = new List<Transform>();
    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        
    }

    /// <summary>
    /// Camera should be one of the last things to update, so that the character and enemies have time to update
    /// their positions before updateing the camera's position
    /// </summary>
    private void LateUpdate()
    {
        
    }
    #endregion monobehaviour methods

    public void AddSecondaryTargetToFollow(Transform transformToAdd)
    {

    }

    public void RemoveSecondaryTargetToFollow(Transform trasformToRemove)
    {

    }
}
