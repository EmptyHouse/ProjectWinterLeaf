using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraFollow : MonoBehaviour, ICameraFocusable {

    #region ICameraFocusable methods
    public Vector3 GetPosition()
    {
        return this.transform.position;
    }

    public Vector2 GetSize()
    {
        return new Vector2(1, 1);
    }

    public bool IsActive()
    {
        return true;
    }
    #endregion ICameraFocusable methods
}
