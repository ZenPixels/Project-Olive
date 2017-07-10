using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterCat : BaseCharacterClass {
	
	public CharacterCat(){
		Name = "Kittycat";
		Description = "Kittycat is a sassy cat princess";
		JobPrincess baseJob = new JobPrincess();
		Jobs.Add (baseJob);
		ActiveJobIndex = 0;
		TextureName = "ac_kitty";
	}
}
