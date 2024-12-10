using UnityEngine;

public class PlayerCombat : CombatReceiver
{
    protected override void Start()
    {
        base.Start();
        factionID = GetComponent<PlayerController>().GetFactionID();
    }

    public override void TakeDamage(float amount)
    {
        Debug.Log("Take Damage");
        base.TakeDamage(amount);
        EventsManager.instance.onHealthChanged.Invoke(currentHP / maxHP);
    }

    public override void Die()
    {
        base.Die();
        GetComponent<PlayerController>().TriggerDeath();
        EventsManager.instance.onPlayerDied.Invoke();
    }
}
