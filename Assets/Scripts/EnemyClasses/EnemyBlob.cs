using UnityEngine;
using System.Collections;

public class EnemyBlob : BaseEnemyClass {
	public EnemyBlob(){
		Name = "Blob";
		Description = "A gross blob";
		MaxHealth = 100;
		CurrentHealth = MaxHealth;
		Initiative = 3;
	}
}
