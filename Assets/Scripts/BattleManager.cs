using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Olive {
	public class BattleManager : MonoBehaviour { 
		private List<BaseEntityClass> entities;

		/*
		public BattleManager() {

		}

		public BattleManager(List<BaseEnemyClass> enemies, List<BaseCharacterClass> party) {
			foreach(BaseEnemyClass enemy in enemies) {
				entities.Add (enemy);
			}

			foreach(BaseCharacterClass character in party) {
				entities.Add (character);
			}

			entities.Sort(delegate(BaseEntityClass a, BaseEntityClass b) {
				return (a.Initiative).CompareTo(b.Initiative);
			});
		}
		*/



		public void ExecuteRound() {

		}

		public void ExecuteCharacterTurn(BaseCharacterClass character) {

		}

		public void ExecuteEnemyTurn(BaseEnemyClass enemy) {

		}

		public void CalculateDamage(BaseAbilityClass ability, BaseEntityClass defender) {

		}
	}
}
