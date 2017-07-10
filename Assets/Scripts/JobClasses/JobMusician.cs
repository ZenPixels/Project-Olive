using System;

public class JobMusician : BaseJobClass
{
	public override string TitleSuffix {
		get {
			if (Level < 4) {
				return string.Empty;
			}

			if (Level < 9) {
				return string.Empty;
			}

			if (Level < 14) {
				return string.Empty;
			}

			if (Level < 19) {
				return string.Empty;
			}

			if (Level < 24) {
				return string.Empty;
			}

			return " the Rockstar";
		}
	}

	public override string TitlePrefix {
		get {
			if (Level < 4) {
				return "Tone Deaf ";
			}

			if (Level < 9) {
				return "Gutter Punk ";
			}

			if (Level < 14) {
				return "Indie Musician ";
			}

			if (Level < 19) {
				return "Pop Star ";
			}

			if (Level < 24) {
				return "Rockin' ";
			}

			return "World Famous ";
		}
	}

	public JobMusician  ()
	{
		JobName = "Musician";
		AbilityPoints = 0;

		ItemEquipment baseChest = new ItemEquipment ("Dirty T-Shirt");
		baseChest.Defense = 2;
		baseChest.EnergyRegen = 0;
		baseChest.SmartsMod = 0;
		baseChest.SwiftMod = 0;
		baseChest.AwesomeMod = 1;
		baseChest.GutsMod = 1;
		baseChest.Damage = 0;
		baseChest.MaxHealthMod = 0;

		ItemEquipment baseWeapon = new ItemEquipment ("Broken Guitar");
		baseWeapon.Defense = 0;
		baseWeapon.EnergyRegen = 0;
		baseWeapon.SmartsMod = 0;
		baseWeapon.SwiftMod = 0;
		baseWeapon.AwesomeMod = 0;
		baseWeapon.GutsMod = 0;
		baseWeapon.Damage = 2;
		baseWeapon.MaxHealthMod = 0;

		ItemEquipment baseAccessory = new ItemEquipment ("Red Bandana");
		baseAccessory.Defense = 0;
		baseAccessory.EnergyRegen = 1;
		baseAccessory.SmartsMod = 0;
		baseAccessory.SwiftMod = 0;
		baseAccessory.AwesomeMod = 1;
		baseAccessory.GutsMod = 0;
		baseAccessory.Damage = 0;
		baseAccessory.MaxHealthMod = 2;

		ItemChest = baseChest;
		ItemWeapon = baseWeapon;
		ItemAccessory = baseAccessory;

		AddAbility (new BaseAbilityClass ("Single Attack"));
		AddAbility (new BaseAbilityClass ("Area Attack"));
		AddAbility (new BaseAbilityClass ("Single Buff"));
		AddAbility (new BaseAbilityClass ("Area Buff"));
	}
}
