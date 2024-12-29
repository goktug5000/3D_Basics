using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : Health
{
    [SerializeField] private TextMeshPro healthText;

    public override void TakeDamage(GameObject hitter, float damage)
    {
        base.TakeDamage(hitter, damage);
        UpdateHpBar();
    }
    public override void Regen()
    {
        base.Regen();
        UpdateHpBar();
    }

    public void UpdateHpBar()
    {
        healthText.text = Mathf.FloorToInt(HP).ToString() + "/" + Mathf.FloorToInt(HP_Max).ToString();
    }
    public override void Die()
    {
        Debug.Log(this.gameObject.name + " öldü");
    }
}
