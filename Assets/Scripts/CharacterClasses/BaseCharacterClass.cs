using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacterClass : BaseEntityClass {
	public int ActiveJobIndex { get; set; }

	public ItemEquipment ActiveJobWeapon {
		get { return ActiveJob.ItemWeapon; }
		set { ActiveJob.ItemWeapon = value; }
	}

	public ItemEquipment ActiveJobChest {
		get { return ActiveJob.ItemChest; }
		set { ActiveJob.ItemChest = value; }
	}

	public ItemEquipment ActiveJobAccessory {
		get { return ActiveJob.ItemAccessory; }
		set { ActiveJob.ItemAccessory = value; }
	}

	private string titlePrefix;
	private string titleSuffix;

	private List<BaseJobClass> jobs;
	// private int activeJobIndex;
	private int currentEnergy;
	private int energyRegen;

	public string FullCharacterName {
		get { 
			return ActiveJob.TitlePrefix + Name + ActiveJob.TitleSuffix;
		}
	}

	public BaseJobClass ActiveJob {
		get { return jobs [ActiveJobIndex]; }
	}

	public int EffectiveGuts {
		get { 
			int returnGuts = ActiveJob.Guts + ActiveJobChest.GutsMod + ActiveJobAccessory.GutsMod + ActiveJobWeapon.GutsMod;
			return returnGuts < 0 ? 0 : returnGuts;
		}
	}

	public int EffectiveAwesomeness {
		get {  
			int returnAwesomeness = ActiveJob.Awesomeness + ActiveJobChest.AwesomeMod + ActiveJobAccessory.AwesomeMod + ActiveJobWeapon.AwesomeMod;
			return returnAwesomeness < 0 ? 0 : returnAwesomeness;
		}
	}

	public override int Initiative {
		get { 
			int returnSwiftness = ActiveJob.Swiftness + ActiveJobChest.SwiftMod + ActiveJobAccessory.SwiftMod + ActiveJobWeapon.SwiftMod;
			return returnSwiftness < 0 ? 0 : returnSwiftness;
		}
	}

	public int EffectiveSmarts {
		get { 
			int returnSmarts = ActiveJob.Smarts + ActiveJobChest.SmartsMod + ActiveJobAccessory.SmartsMod + ActiveJobWeapon.SmartsMod;
			return returnSmarts < 0 ? 0 : returnSmarts;
		} 
	}

	public int Defense {
		get { 
			int returnDefense = ActiveJobChest.Defense + ActiveJobAccessory.Defense + ActiveJobWeapon.Defense + Mathf.RoundToInt(EffectiveGuts * 0.25f);
			return returnDefense < 0 ? 0 : returnDefense;
		}
	}

	public int Dodge {
		get { 
			int returnDodge = Mathf.RoundToInt(Initiative * 0.25f);
			return returnDodge < 0 ? 0 : returnDodge;
		}
	}

	new public int MaxHealth {
		get {
			int returnMaxHealth = Mathf.RoundToInt(EffectiveGuts * 1.5f);

			return returnMaxHealth < 0 ? 0 : returnMaxHealth;
		}
	}

	public int MaxEnergy {
		get {
			int returnMaxEnergy = Mathf.RoundToInt(EffectiveSmarts * 1.5f);

			return returnMaxEnergy < 0 ? 0 : returnMaxEnergy;
		}
	}

	public List<BaseJobClass> Jobs {
		get { return jobs; }
		set { jobs = value; }
	}

	public int CurrentEnergy {
		get { return currentEnergy; }
		set {
			if (currentEnergy + value < 0) {  
				currentEnergy = 0;
			} else if ((currentEnergy + value) > MaxEnergy) {
				currentEnergy = MaxEnergy;
			} else {
				currentEnergy += value;
			}
		}
	}

	public BaseCharacterClass() {
		jobs = new List<BaseJobClass> ();
	}
}