using UnityEngine;
using System.Collections;

public class EnemyWolf : BaseEnemyClass {	
	public EnemyWolf() {
		Name = "Wolf";
		Description = "A mean wolf";
		MaxHealth = 100;
		CurrentHealth = MaxHealth;
		TextureName = "ac_wolf";
		Initiative = 1;
	}
}
