using System;

public class JobPrincess : BaseJobClass
{
	public override string TitleSuffix {
		get {
			if (Level < 4) {
				return " the Hopeless";
			}

			if (Level < 9) {
				return string.Empty;
			}

			if (Level < 14) {
				return " the Fancy";
			}

			if (Level < 19) {
				return " of the People";
			}

			if (Level < 24) {
				return " the Majestic";
			}

			return string.Empty;
		}
	}

	public override string TitlePrefix {
		get {
			if (Level < 4) {
				return string.Empty;
			}

			if (Level < 9) {
				return "Basic ";
			}

			if (Level < 14) {
				return string.Empty;
			}

			if (Level < 19) {
				return "Beloved ";
			}

			if (Level < 24) {
				return "Royal ";
			}

			return "Queen ";
		}
	}

	public JobPrincess ()
	{
		JobName = "Princess";
		AbilityPoints = 0;

		ItemEquipment baseChest = new ItemEquipment ("Royal Gown");
		baseChest.Defense = 2;
		baseChest.EnergyRegen = 0;
		baseChest.SmartsMod = 0;
		baseChest.SwiftMod = 0;
		baseChest.AwesomeMod = 1;
		baseChest.GutsMod = 1;
		baseChest.Damage = 0;
		baseChest.MaxHealthMod = 0;

		ItemEquipment baseWeapon = new ItemEquipment ("Royal Wand");
		baseWeapon.Defense = 0;
		baseWeapon.EnergyRegen = 0;
		baseWeapon.SmartsMod = 0;
		baseWeapon.SwiftMod = 0;
		baseWeapon.AwesomeMod = 0;
		baseWeapon.GutsMod = 0;
		baseWeapon.Damage = 2;
		baseWeapon.MaxHealthMod = 0;

		ItemEquipment baseAccessory = new ItemEquipment ("Royal Princess Hat");
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

		AddAbility (new BaseAbilityClass ("Wand Attack"));
		AddAbility (new BaseAbilityClass ("Glitter Dust"));
		AddAbility (new BaseAbilityClass ("Royal Decree"));
	}

	public override void LevelUp ()
	{
		base.LevelUp ();

		if (Level == 10) {
			AddAbility (new BaseAbilityClass ("Tea Party"));
		}

		if (Level == 20) {
			AddAbility (new BaseAbilityClass ("Rainbow Sparkle Blast"));
		}
	}
}
