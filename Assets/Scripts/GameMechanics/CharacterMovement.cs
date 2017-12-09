using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    #region const variables
    private const float MIN_MOVEMENT_THRESHOLD = 0.3f;
    #endregion const variables
    #region main variables
    public float walkSpeed = 15;
    public float runSpeed = 25;

    public float acceleration = 15;


    private Animator anim;
    private float hInput;
    private float vInput;
    private Vector2 currentVelocity = Vector2.zero;
    #endregion main variables

    #region monobehaviour methods

    private void Awake()
    {
        this.anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //UpdateMovement();
    }

    private void OnValidate()
    {
        if (walkSpeed < 0) walkSpeed = 0;
        if (runSpeed < 0) runSpeed = 0;
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

    public void UpdateMovement()
    {
        Vector2 goalSpeed = Vector2.zero;

        if (Mathf.Abs(this.hInput) > MIN_MOVEMENT_THRESHOLD)
        {
            goalSpeed.x = Mathf.Sign(this.hInput);
        }
        if (Mathf.Abs(this.vInput) > MIN_MOVEMENT_THRESHOLD)
        {
            goalSpeed.y = Mathf.Sign(this.vInput);
        }
        goalSpeed = goalSpeed.normalized * runSpeed;

        currentVelocity = Vector2.MoveTowards(currentVelocity, goalSpeed, Time.deltaTime * acceleration);

        this.transform.position += (Time.deltaTime * new Vector3(currentVelocity.x, currentVelocity.y, 0));
    }

    
}
