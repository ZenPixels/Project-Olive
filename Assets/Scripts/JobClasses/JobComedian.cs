using System;

public class JobComedian : BaseJobClass
{
	public override string TitleSuffix {
		get {
			if (Level < 4) {
				return " the Unknown Comic";
			}

			if (Level < 9) {
				return " the Prop Comic";
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

			return " Master of Comedy";
		}
	}

	public override string TitlePrefix {
		get {
			if (Level < 4) {
				return string.Empty;
			}

			if (Level < 9) {
				return string.Empty;
			}

			if (Level < 14) {
				return "Sassy ";
			}

			if (Level < 19) {
				return "Sarcastic ";
			}

			if (Level < 24) {
				return "Hilarious ";
			}

			return string.Empty;
		}
	}

	public JobComedian ()
	{
		JobName = "Comedian";
		AbilityPoints = 0;

		ItemEquipment baseChest = new ItemEquipment ("Cheap Suit");
		baseChest.Defense = 2;
		baseChest.EnergyRegen = 0;
		baseChest.SmartsMod = 0;
		baseChest.SwiftMod = 0;
		baseChest.AwesomeMod = 1;
		baseChest.GutsMod = 1;
		baseChest.Damage = 0;
		baseChest.MaxHealthMod = 0;

		ItemEquipment baseWeapon = new ItemEquipment ("Broken Microphone");
		baseWeapon.Defense = 0;
		baseWeapon.EnergyRegen = 0;
		baseWeapon.SmartsMod = 0;
		baseWeapon.SwiftMod = 0;
		baseWeapon.AwesomeMod = 0;
		baseWeapon.GutsMod = 0;
		baseWeapon.Damage = 2;
		baseWeapon.MaxHealthMod = 0;

		ItemEquipment baseAccessory = new ItemEquipment ("Old Joke Book");
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
