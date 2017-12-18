using UnityEngine;

public class CharacterStats : MonoBehaviour {
    #region main variables 
    [Tooltip("The maximum health that a player can be at any given point. Normally health will not go beyond this after collecting health packs")]
    public float maxHealth = 100;


    public CharacterMovement characterMovement { get; private set; }

    public float currentHealth { get; protected set; }
    #endregion main variables


    #region monobehaviour methods
    protected virtual void Awake()
    {
        this.currentHealth = maxHealth;
        this.characterMovement = GetComponent<CharacterMovement>();
    }

    protected virtual void OnValidate()
    {
        if (maxHealth < 1)
        {
            maxHealth = 1;
        }
    }
    #endregion monobehaviour methods


    #region health methods
    public void AddHealth(float healthToAdd)
    {
        this.currentHealth += healthToAdd;
        this.currentHealth = Mathf.Min(this.currentHealth, this.maxHealth);

    }

    public void TakeDamage(float damageToTake)
    {
        this.currentHealth -= damageToTake;
        if (currentHealth <= 0)
        {
            OnCharacterDead();
        }
        this.currentHealth = Mathf.Max(0, this.currentHealth);
    }

    /// <summary>
    /// This method will be called when a character has taken damage and its health has fallen below 0.
    /// </summary>
    public void OnCharacterDead()
    {

    }
    #endregion health methods
}
