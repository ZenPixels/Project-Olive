using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemBaseModifier{
	public int Id { get; set; }
	public string DisplayName { get; set; }
	public int ModGuts { get; set; }
	public int ModAwesomeness { get; set; }
	public int ModSwiftness { get; set; }
	public int ModSmarts { get; set; }
	public int ModDefense { get; set; }
	public int ModDamage { get; set; }
		
	public ItemBaseModifier(int ItemId, string ItemDisplayName, int ItemGuts, int ItemAwesomeness, int ItemSwiftness, int ItemSmarts, int ItemDefense, int ItemDamage){
		Id = ItemId;
		DisplayName = ItemDisplayName;
		ModGuts = ItemGuts;
		ModAwesomeness = ItemAwesomeness;
		ModSwiftness = ItemSwiftness;
		ModSmarts = ItemSmarts;
		ModDefense = ItemDefense;
		ModDamage = ItemDamage;
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