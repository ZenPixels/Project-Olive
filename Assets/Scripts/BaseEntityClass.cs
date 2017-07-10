using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseEntityClass {
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string TextureName { get; set; }
	public Vector3 Position{ get; set; }
	public GameObject EntityGameObject { get; set; }
	public virtual int Initiative { get; set; }
	public int MaxHealth { get; set; }

	private int currentHealth;

	public enum EntityConditions {
		OKAY,
		UNCONSCIOUS
	}

	public int CurrentHealth {
		get { return currentHealth; }
		set {
			if (currentHealth + value < 0) {  
				currentHealth = 0;
			} else if ((currentHealth + value) > MaxHealth) {
				currentHealth = MaxHealth;
			} else {
				currentHealth += value;
			}
		}
	}

	public EntityConditions Condition {
		get {
			return CurrentHealth == 0 ? EntityConditions.UNCONSCIOUS : EntityConditions.OKAY;
		}
	}
}
