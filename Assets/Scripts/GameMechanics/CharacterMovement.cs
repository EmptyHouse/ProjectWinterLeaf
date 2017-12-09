using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    #region main variables
    public float walkSpeed = 15;
    public float runSpeed = 25;

    public float acceleration = 15;


    private Animator anim;
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

}
