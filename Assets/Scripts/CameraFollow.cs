using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    #region main variables
    public float cameraSpeed = 12;

    [Tooltip("A reference to the player to follow. This is the most important unit to follow when calculating camera position")]
    private Transform playerTransform;
    [Tooltip("This list will hold enemy Transforms that the camera shold focus. Typically when in action. Can also be used to focus on important items")]
    private List<Transform> secondaryTargetList = new List<Transform>();

    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        this.playerTransform = this.transform.parent;
        this.transform.SetParent(null);
    }

    /// <summary>
    /// Camera should be one of the last things to update, so that the character and enemies have time to update
    /// their positions before updateing the camera's position
    /// </summary>
    private void LateUpdate()
    {
        Vector3 goalPosition = new Vector3(this.playerTransform.position.x, this.playerTransform.position.y, this.transform.position.z);

        this.transform.position = Vector3.Lerp(this.transform.position, goalPosition, Time.deltaTime * cameraSpeed);
    }
    #endregion monobehaviour methods

    public void AddSecondaryTargetToFollow(Transform transformToAdd)
    {

    }

    public void RemoveSecondaryTargetToFollow(Transform trasformToRemove)
    {

    }
}
