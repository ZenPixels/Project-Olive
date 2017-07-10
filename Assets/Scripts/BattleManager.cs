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

		void Update() {
			if (Input.GetKeyDown ("space")) {
				party[0].ActiveJob.Experience += 20;
				party[1].ActiveJob.Experience += 20;
				party[2].ActiveJob.Experience += 20;

				AnimateDamage (enemies[0]);
			}
		}

		public void ExecuteRound() {

		}

		public void ExecuteCharacterTurn(BaseCharacterClass character) {

		}

		public void ExecuteEnemyTurn(BaseEnemyClass enemy) {

		}

		void CalculateDamage(BaseAbilityClass ability, BaseEntityClass defender) {

		}

		void AnimateDamage(BaseEntityClass entity) {
			iTween.ShakePosition (entity.EntityGameObject, iTween.Hash("x", 0.1f, "y", 0.1f, "time", 0.5f));
		}
	}
}
