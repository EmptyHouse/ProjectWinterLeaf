using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    #region main variables
    [Tooltip("This will determine how much we want to focus on secondary characters. You can set the value between 0 and 1. 0 being no focus on the secondary targets and 1 being full focus on the secondary targets")]
    [Range(0, 1)]
    public float secondaryFocusPercent = .5f;
    public float cameraSpeed = 12;

    [Tooltip("A reference to the player to follow. This is the most important unit to follow when calculating camera position")]
    private Transform playerTransform;
    [Tooltip("This list will hold enemy Transforms that the camera shold focus. Typically when in action. Can also be used to focus on important items")]
    private List<ICameraFocusable> secondaryTargetList = new List<ICameraFocusable>();
    private Vector3 cameraVelocity = Vector3.zero;

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
    private void Update()
    {
        Vector3 goalPosition = new Vector3(this.playerTransform.position.x, this.playerTransform.position.y, this.transform.position.z);

        this.transform.position = Vector3.Lerp(this.transform.position, goalPosition, Time.deltaTime * cameraSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICameraFocusable cameraFocusable = collision.GetComponent<ICameraFocusable>();

        if (cameraFocusable != null)
        {
            AddSecondaryTargetToFollow(cameraFocusable);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ICameraFocusable cameraFocusable = collision.GetComponent<ICameraFocusable>();

        if (cameraFocusable != null)
        {
            RemoveSecondaryTargetToFollow(cameraFocusable);
        }
    }
    #endregion monobehaviour methods


    #region secondary target methods
    /// <summary>
    /// Adds a secondary target to the list. Because it is added to the list, does not necessarily automatically
    /// make the camera follow it. The object must also be engaged with the player or in an active state
    /// </summary>
    /// <param name="cameraFocusable"></param>
    public void AddSecondaryTargetToFollow(ICameraFocusable cameraFocusable)
    {
        if (!secondaryTargetList.Contains(cameraFocusable))
        {
            secondaryTargetList.Add(cameraFocusable);
        }
    }

    /// <summary>
    /// Removes a target from the list. This will typically be called an enemy is out of reach but should also be called when an enemy
    /// dies so that the camera does not follow it after the fact
    /// </summary>
    /// <param name="cameraFocusable"></param>
    public void RemoveSecondaryTargetToFollow(ICameraFocusable cameraFocusable)
    {
        if (secondaryTargetList.Contains(cameraFocusable))
        {
            secondaryTargetList.Remove(cameraFocusable);
        }
    }

    /// <summary>
    /// Returns an average offset that the secondary focusable targets will be located.
    /// </summary>
    /// <returns></returns>
    private Vector2 GetSecondaryTargetAverage()
    {
        Vector2 secondaryGoalTarget = Vector2.zero;
        int activeCameraFocusableCount = 0;
        foreach (ICameraFocusable cameraFocusable in this.secondaryTargetList)
        {
            if (cameraFocusable.IsActive())
            {
                Vector3 pos = cameraFocusable.GetPosition();
                secondaryGoalTarget += ((new Vector2(pos.x, pos.y) - new Vector2(playerTransform.position.x, playerTransform.position.y)) * secondaryFocusPercent);
                activeCameraFocusableCount++;
            }
        }
        if (activeCameraFocusableCount <= 0) return Vector2.zero;

        return secondaryGoalTarget;
    }
    #endregion secondary target methods

    
}
