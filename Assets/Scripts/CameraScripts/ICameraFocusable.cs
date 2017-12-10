using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICameraFocusable {
    /// <summary>
    /// Returns the transform position of the object the camera is trying to focus on
    /// </summary>
    /// <returns></returns>
    Vector3 GetPosition();
    /// <summary>
    /// Should reutrn a Vector2 represent the dimensions of the enemy that is currently trying to be focued on
    /// It may be best to use a box collider to get a more accurate size representation
    /// </summary>
    /// <returns></returns>
    Vector2 GetSize();
    /// <summary>
    /// Is Active refers to whether or not the camera should focus on the object or not
    /// If it is in view, but is not engaged with the player, it may not need to be
    /// focused just yet.
    /// </summary>
    /// <returns></returns>
    bool IsActive();
}
