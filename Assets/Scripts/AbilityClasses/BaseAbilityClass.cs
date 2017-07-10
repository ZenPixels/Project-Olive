using System;

public class BaseAbilityClass
{
	private string name;
	private bool active;

	public string Name {
		get { return name; }
		set { name = value; }
	}

	public bool Active {
		get { return active; }
		set { active = value; }
	}

	public BaseAbilityClass ()
	{
		active = false;
	}

	public BaseAbilityClass (string abilityName)
	{
		name = abilityName;
		active = false;
	}
}
