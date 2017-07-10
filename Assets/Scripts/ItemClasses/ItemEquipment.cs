using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ItemEquipment : BaseItemClass {
	// const int PREFIX_CHANCE = 10;
	// const int SUFFIX_CHANCE = 10;

	private int defense;
	private int damage;
	private string name;
	private ItemBaseModifier prefixModifier;
	private ItemBaseModifier suffixModifier;

	public enum EquipmentSlots {
		CHEST,
		ACCESSORY,
		WEAPON
	}

	public enum EquipmentSets
	{
		PRINCESS,
		COMEDIAN,
		ROCKER,
		POLICE,
		FIREFIGHTER,
		DOCTOR,
		BUSINESS,
		SOCCER,
		WIZARD,
		SOLDIER
	}

	private EquipmentSlots equipmentSlot;
	private EquipmentSets equipmentType;

	public string Name{
		get { return name; }
		set { name = value; }
	}

	public string FullName{
		get {  
			string returnName = prefixModifier == null ? name : prefixModifier.DisplayName + " " + name;
			returnName = suffixModifier == null ? returnName : returnName + " " + suffixModifier.DisplayName;

			return returnName;
		}
	}

	public int Defense {
		get { 
			int returnDefense = defense;
			if (prefixModifier != null) {
				returnDefense += prefixModifier.ModDefense;
			}

			if (suffixModifier != null) {
				returnDefense += suffixModifier.ModDefense;
			}

			return returnDefense;
		}
		set { defense = value; }
	}

	public int Damage {
		get { 
			int returnDamage = damage;
			if (prefixModifier != null) {
				returnDamage += prefixModifier.ModDamage;
			}

			if (suffixModifier != null) {
				returnDamage += suffixModifier.ModDamage;
			}

			return returnDamage;
		}
		set { damage = value; }
	}

	public ItemEquipment(string itemName) {
		MaxStackSize = 1;
		name = itemName;

		/*
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		int prefixRoll = UnityEngine.Random.Range(0, 100);

		Debug.Log("PreRoll : " + prefixRoll.ToString());

		if (prefixRoll <= PREFIX_CHANCE) {
			List<ItemBaseModifier> armorPrefixes = ItemBaseModifier.GetArmorPrefixes ();
			UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
			// rnd = new UnityEngine.Random();
			prefixModifier = armorPrefixes [UnityEngine.Random.Range (0, armorPrefixes.Count)];
		}

		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		int suffixRoll = UnityEngine.Random.Range(0, 100);

		Debug.Log("SuffixRoll : " + suffixRoll.ToString());
	
		if (suffixRoll <= SUFFIX_CHANCE) {
			List<ItemBaseModifier> armorSuffixes = ItemBaseModifier.GetArmorSuffixes ();
			UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
			// rnd = new UnityEngine.Random();
			suffixModifier = armorSuffixes [UnityEngine.Random.Range (0, armorSuffixes.Count)];
		}
		*/
	}

	/*
	private static List<string> GetOffHandTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("Dog Stuffie");
		typeList.Add ("Pinwheel");
		typeList.Add ("Cat Stuffie");
		typeList.Add ("Cupcake");
		typeList.Add ("Chapter Book");
		typeList.Add ("Smelly Markers");
		typeList.Add ("Glue Bottle");

		return typeList;
	}

	public static string GetRandomOffHand (){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetOffHandTypes () [UnityEngine.Random.Range (0, GetOffHandTypes ().Count - 1)];

		return itemType;
	}

	private static List<string> GetChestTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("T-Shirt");
		typeList.Add ("Sweater");
		typeList.Add ("Shirt");
		typeList.Add ("Emoji Shirt");
		typeList.Add ("Dog Shirt");
		typeList.Add ("Cat Shirt");

		return typeList;
	}

	public static string GetRandomChest(){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetChestTypes () [UnityEngine.Random.Range (0, GetChestTypes ().Count - 1)];

		return itemType;
	}

	private static List<string> GetFeetTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("Boots");
		typeList.Add ("Sandals");
		typeList.Add ("Sneakers");
		typeList.Add ("High Heels");
		typeList.Add ("Galoshes");
		typeList.Add ("Slippers");

		return typeList;
	}

	public static string GetRandomFeet(){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetFeetTypes () [UnityEngine.Random.Range (0, GetFeetTypes ().Count - 1)];

		return itemType;
	}

	private static List<string> GetAccessoryTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("Bracelet");
		typeList.Add ("Necklace");
		typeList.Add ("Ring");
		typeList.Add ("Monocle");
		typeList.Add ("Earrings");
		typeList.Add ("Brooch");

		return typeList;
	}

	public static string GetRandomAcessory(){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetAccessoryTypes () [UnityEngine.Random.Range (0, GetAccessoryTypes ().Count - 1)];

		return itemType;
	}

	private static List<string> GetHeadTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("Baseball Cap");
		typeList.Add ("Crown");
		typeList.Add ("Tiara");
		typeList.Add ("Helmet");
		typeList.Add ("Scarf");
		typeList.Add ("Top Hat");

		return typeList;
	}

	public static string GetRandomHead(){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetHeadTypes () [UnityEngine.Random.Range (0, GetHeadTypes ().Count - 1)];

		return itemType;
	}

	private static List<string> GetPantsTypes(){
		List<string> typeList = new List<string> ();
		typeList.Add ("Trousers");
		typeList.Add ("Jeans");
		typeList.Add ("Slacks");
		typeList.Add ("Skirt");
		typeList.Add ("Leggings");
		typeList.Add ("Cargo Shorts");

		return typeList;
	}

	public static string GetRandomPants(){
		UnityEngine.Random.seed = System.DateTime.Now.Millisecond;
		string itemType = GetPantsTypes () [UnityEngine.Random.Range (0, GetPantsTypes ().Count - 1)];

		return itemType;
	}
	*/
}
