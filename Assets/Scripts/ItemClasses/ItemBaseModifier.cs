using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemBaseModifier{
	private int id;
	private string displayName;
	private int modGuts;
	private int modAwesomeness;
	private int modSwiftness;
	private int modSmarts;
	private int modDefense;
	private int modDamage;

	public int Id {
		get { return id; }
		set { id = value; }
	}

	public string DisplayName {
		get { return displayName; }
		set { displayName = value; }
	}

	public int ModGuts {
		get { return modGuts; }
		set { modGuts = value; }
	}

	public int ModAwesomeness {
		get { return modAwesomeness; }
		set { modAwesomeness = value; }
	}

	public int ModSwiftness {
		get { return modSwiftness; }
		set { modSwiftness = value; }
	}

	public int ModSmarts {
		get { return modSmarts; }
		set { modSmarts = value; }
	}

	public int ModDefense {
		get { return modDefense; }
		set { modDefense = value; }
	}

	public int ModDamage {
		get { return modDamage; }
		set { modDamage = value; }
	}
		
	public ItemBaseModifier(int ItemId, string ItemDisplayName, int ItemGuts, int ItemAwesomeness, int ItemSwiftness, int ItemSmarts, int ItemDefense, int ItemDamage){
		id = ItemId;
		displayName = ItemDisplayName;
		modGuts = ItemGuts;
		modAwesomeness = ItemAwesomeness;
		modSwiftness = ItemSwiftness;
		modSmarts = ItemSmarts;
		modDefense = ItemDefense;
		modDamage = ItemDamage;
	}

	/*
	public static List<ItemBaseModifier> GetArmorPrefixes(){
		List<ItemBaseModifier> prefixList = new List<ItemBaseModifier> ();

		prefixList.Add (new ItemBaseModifier (1, "Frilly", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (2, "Soiled", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (3, "Gleaming", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (4, "Flowery", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (5, "Slime Encrusted", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (6, "Trendy", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (7, "Fuzzy", 0, 0, 0, 0));
		prefixList.Add (new ItemBaseModifier (8, "Unicorn Covered", 0, 0, 0, 0));

		return prefixList;
	}

	public static List<ItemBaseModifier> GetArmorSuffixes(){
		List<ItemBaseModifier> suffixList = new List<ItemBaseModifier> ();

		suffixList.Add (new ItemBaseModifier (1, "of House Kittycat", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (2, "of the Brave", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (3, "of the Strong", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (4, "of the Smart", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (5, "of the Sneaky", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (6, "of Fun", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (7, "of Boogers", 0, 0, 0, 0));
		suffixList.Add (new ItemBaseModifier (8, "of the Southern Isles", 0, 0, 0, 0));

		return suffixList;
	}
	*/
}