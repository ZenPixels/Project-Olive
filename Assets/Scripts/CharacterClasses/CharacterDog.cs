using UnityEngine;
using System.Collections;

public class CharacterDog : BaseCharacterClass {
	public CharacterDog() {
		Name = "Petey";
		Description = "Petey loves to ROCK OUT";
		JobMusician baseJob = new JobMusician ();
		Jobs.Add (baseJob);
		ActiveJobIndex = 0;
		TextureName = "ac_dog";
	}
}
