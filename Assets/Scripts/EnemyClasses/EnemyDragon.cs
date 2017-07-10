using UnityEngine;
using System.Collections;

public class EnemyDragon : BaseEnemyClass {
	public EnemyDragon(){
		Name = "Dragon";
		Description = "A fire breathing dragon";
		MaxHealth = 100;
		CurrentHealth = MaxHealth;
		Initiative = 2;
	}
}
