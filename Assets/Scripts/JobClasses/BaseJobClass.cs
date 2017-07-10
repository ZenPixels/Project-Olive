using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void JobLevelEventHandler();

public class BaseJobClass {
	public string JobName { get; set; }
	public ItemEquipment ItemWeapon { get; set; }
	public ItemEquipment ItemAccessory { get; set; }
	public ItemEquipment ItemChest { get; set; }
	public int Level { get; set; }
	public int Guts { get; set; }
	public int Awesomeness { get; set; }
	public int Swiftness { get; set; }
	public int Smarts { get; set; }
	public int AbilityPoints { get; set; }
	public List<BaseAbilityClass> AbilityList { get; set; }

	private int experience;

	public event JobLevelEventHandler JobHasLeveled;

	public int Experience {
		get { return experience; }
		set { 
			experience = value;

			if ((experience / 100) > Level) {
				LevelUp ();
			}
		}
	}

	public int NextLevel { 
		get { return (Level * 100) + 100; }
	}

	public virtual string TitleSuffix {
		get { return string.Empty; }
	}

	public virtual string TitlePrefix {
		get { return string.Empty; }
	}

	public List<BaseAbilityClass> ActiveAbilityList {
		get { return AbilityList.FindAll (FindActiveAbility); }
	}

	public List<BaseAbilityClass> InactiveAbilityList {
		get { return AbilityList.FindAll (FindInactiveAbility); }
	}

	public BaseJobClass() {
		AbilityList = new List<BaseAbilityClass> ();
		Experience = 0;
		Level = 1;
	}

	public void AddAbility(BaseAbilityClass ability) {
		AbilityList.Add(ability);
		ability.Active = (AbilityList.Count <= 3);
	}

	private static bool FindActiveAbility(BaseAbilityClass ability)
	{
		return ability.Active;
	}

	private static bool FindInactiveAbility(BaseAbilityClass ability)
	{
		return !ability.Active;
	}

	public virtual void LevelUp() { 
		Level++;
		AbilityPoints += 3;
		JobHasLeveled();
	}
}
