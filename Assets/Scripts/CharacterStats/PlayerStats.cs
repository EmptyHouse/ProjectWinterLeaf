using UnityEngine;

public class PlayerStats : CharacterStats {
    public PlayerController playerController { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        this.playerController = GetComponent<PlayerController>();

    }
}
