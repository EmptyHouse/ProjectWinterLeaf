using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class PlayerController : MonoBehaviour {
    #region main variables
    private CharacterMovement characterMovement;
    #endregion main varialbes

    #region monobehaviour methods
    private void Awake()
    {
        this.characterMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        characterMovement.SetHorizontalDirection(Input.GetAxisRaw("Horizontal"));
        characterMovement.SetVerticalDirection(Input.GetAxisRaw("Vertical"));
        characterMovement.UpdateMovement();

    }
    #endregion monobehaviour methods
}
