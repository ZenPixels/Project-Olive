using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void JobLevelEventHandler();

public class BaseJobClass {
	private string jobName;
	private ItemEquipment itemWeapon;
	private ItemEquipment itemAccessory;
	private ItemEquipment itemChest;
	private int experience;
	private int level;
	private int guts;
	private int awesomeness;
	private int swiftness;
	private int smarts;
	private int abilityPoints;

	private List<BaseAbilityClass> abilityList;

	public event JobLevelEventHandler JobHasLeveled;

	public string JobName {
		get { return jobName; }
		set { jobName = value; }
	}

	public ItemEquipment ItemWeapon {
		get { return itemWeapon; }
		set { itemWeapon = value; }
	}

	public ItemEquipment ItemChest {
		get { return itemChest; }
		set { itemChest = value; }
	}

	public ItemEquipment ItemAccessory {
		get { return itemAccessory; }
		set { itemAccessory = value; }
	}

	public int Guts {
		get { return guts; }
		set { guts = value; }
	}

	public int Awesomeness {
		get { return awesomeness; }
		set { awesomeness = value; }
	}

	public int Swiftness {
		get { return swiftness; }
		set { swiftness = value; }
	}

	public int Smarts {
		get { return smarts; }
		set { smarts = value; }
	}

	public int Experience {
		get { return experience; }
		set { 
			experience = value;

			if ((experience / 100) > level) {
				LevelUp ();
			}
		}
	}

	public int NextLevel { 
		get { return (level * 100) + 100; }
	}

	public int Level {
		get { return level; }
		set { level = value; }
	}

	public int AbilityPoints {
		get { return abilityPoints; }
		set { abilityPoints = value; }
	}

	public virtual string TitleSuffix {
		get { return string.Empty; }
	}

	public virtual string TitlePrefix {
		get { return string.Empty; }
	}

	public List<BaseAbilityClass> AbilityList {
		get { return abilityList; }
		set { abilityList = value; }
	}

	public List<BaseAbilityClass> ActiveAbilityList {
		get { return abilityList.FindAll (FindActiveAbility); }
	}

	public List<BaseAbilityClass> InactiveAbilityList {
		get { return abilityList.FindAll (FindInactiveAbility); }
	}

	public BaseJobClass() {
		abilityList = new List<BaseAbilityClass> ();
		experience = 0;
		level = 1;
	}

	public void AddAbility(BaseAbilityClass ability) {
		abilityList.Add(ability);
		ability.Active = (abilityList.Count <= 3);
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
		level++;
		abilityPoints += 3;
		JobHasLeveled();
	}
}
