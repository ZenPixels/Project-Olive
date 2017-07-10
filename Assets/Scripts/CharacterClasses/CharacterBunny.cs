using UnityEngine;
using System.Collections;

public class CharacterBunny : BaseCharacterClass {
	public CharacterBunny(){
		Name = "Bunny";
		Description = "Bunny is a fun bunny";
		JobComedian baseJob = new JobComedian ();
		Jobs.Add (baseJob);
		ActiveJobIndex = 0;
		TextureName = "ac_bunny";
	}
}
