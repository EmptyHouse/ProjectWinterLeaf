using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    [Tooltip("The maximum health that a player can be at any given point. Normally health will not go beyond this after collecting health packs")]
    public float maxHealth = 100;


    public CharacterMovement characterMovement { get; private set; }
    public PlayerController playerController { get; private set; }
	// Use this for initialization
	void Start () {
        this.characterMovement = GetComponent<CharacterMovement>();
        this.playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
