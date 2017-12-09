using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    #region main variables
    public float walkSpeed = 15;
    public float runSpeed = 25;

    public float acceleration = 15;


    private Animator anim;
    private float hInput;
    private float vInput;
    #endregion main variables

    #region monobehaviour methods

    private void Awake()
    {
        this.anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }
    #endregion monobehaviour methods

    #region set directions
    /// <summary>
    /// Sets the scale of the horizontal input. Should be a number between -1 and 1. 
    /// 
    /// </summary>
    /// <param name="hInput"></param>
    public void SetHorizontalDirection(float hInput)
    {
        this.hInput = Mathf.Sign(hInput) * Mathf.Min(1, Mathf.Abs(hInput));
    }

    public void SetVerticalDirection(float vInput)
    {
        this.vInput = Mathf.Sign(vInput) * Mathf.Min(1, Mathf.Abs(vInput));
    }
    #endregion set directions

    private void UpdateMovement()
    {

    }

}
