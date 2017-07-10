using System;

public class JobChef : BaseJobClass
{
	public override string TitleSuffix {
		get {
			if (Level < 4) {
				return "Chef I";
			}

			if (Level < 9) {
				return "Chef II";
			}

			if (Level < 14) {
				return "Chef III";
			}

			if (Level < 19) {
				return "Chef IV";
			}

			if (Level < 24) {
				return "Chef V";
			}

			return "World Renowned Chef";
		}
	}

	public override string TitlePrefix {
		get { return "Cook"; }
	}

	public JobChef  ()
	{
		JobName = "Chef";
		AbilityPoints = 0;

		ItemEquipment baseChest = new ItemEquipment ("Dirty Apron");
		baseChest.Defense = 2;
		baseChest.EnergyRegen = 0;
		baseChest.SmartsMod = 0;
		baseChest.SwiftMod = 0;
		baseChest.AwesomeMod = 1;
		baseChest.GutsMod = 1;
		baseChest.Damage = 0;
		baseChest.MaxHealthMod = 0;

		ItemEquipment baseWeapon = new ItemEquipment ("Rusty Suacepan");
		baseWeapon.Defense = 0;
		baseWeapon.EnergyRegen = 0;
		baseWeapon.SmartsMod = 0;
		baseWeapon.SwiftMod = 0;
		baseWeapon.AwesomeMod = 0;
		baseWeapon.GutsMod = 0;
		baseWeapon.Damage = 2;
		baseWeapon.MaxHealthMod = 0;

		ItemEquipment baseAccessory = new ItemEquipment ("Moldy Chef Hat");
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
