using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class CustomCollision : MonoBehaviour {
    #region main variables
    public BoxCollider2D boxCollider;
    #endregion main variables

    #region monobehaviour methods
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        
    }
    #endregion monobehaviour methods



}
