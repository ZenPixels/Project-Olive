using UnityEngine;
using System.Collections;

namespace Olive {
	using System.Collections.Generic;		
	using UnityEngine.UI;					

	public class GameManager : MonoBehaviour {
		
		public static GameManager instance = null;
		private GUIStyle guiStyle;
		private List<BaseCharacterClass> party;
		private List<BaseEnemyClass> enemies;
		public Dictionary<string, Sprite> dictSprites;
		private SpriteRenderer renderer;
		private BattleManager battleScript;

		void Awake() {
			if (instance == null)
				instance = this;
			else if (instance != this)
				Destroy(gameObject);	

			DontDestroyOnLoad(gameObject);

			renderer = new SpriteRenderer();
			dictSprites = new Dictionary<string, Sprite>();
			party = new List<BaseCharacterClass>();
			enemies = new List<BaseEnemyClass>();   
			guiStyle = new GUIStyle();

			//Get a component reference to the attached BattleManager script
			battleScript = GetComponent<BattleManager>();

			//Call the InitGame function to initialize 
			InitGame();
		}
			
		void InitGame() {
			
			CharacterCat cat = new CharacterCat ();
			CharacterBunny bunny = new CharacterBunny ();
			CharacterDog dog = new CharacterDog ();

			EnemyWolf enemyWolf = new EnemyWolf();

			Sprite[] sprites = Resources.LoadAll<Sprite>("animal_crossing_example_tile");

			foreach (Sprite sprite in sprites)
			{
				dictSprites.Add (sprite.name, sprite);
			}

			cat.Position= Camera.main.ViewportToWorldPoint(new Vector3(0.6f,0.6f,1f));
			dog.Position= Camera.main.ViewportToWorldPoint(new Vector3(0.6f,0.4f,1f));
			bunny.Position= Camera.main.ViewportToWorldPoint(new Vector3(0.6f,0.2f,1f));
			enemyWolf.Position = Camera.main.ViewportToWorldPoint(new Vector3(0.2f,0.4f,1f));

			party.Add (cat);
			party.Add (bunny);
			party.Add (dog);
			enemies.Add (enemyWolf);

			party[0].ActiveJob.JobHasLeveled += new JobLevelEventHandler(HandleJobLevelEvent);
			party[1].ActiveJob.JobHasLeveled += new JobLevelEventHandler(HandleJobLevelEvent);
			party[2].ActiveJob.JobHasLeveled += new JobLevelEventHandler(HandleJobLevelEvent);

			InitializeCharacterObjects (party);
			InitializeEnemyObjects (enemies);
		}

		void OnGUI () {
			guiStyle.fontSize = 16;

			for (int i = 0; i < party.Count; i++) {
				var y_pos = i * 30;
				GUI.Label (new Rect (50, y_pos, 800, 30), 
					(i + 1).ToString() + ") " + party[i].FullCharacterName +
					" | Level " + party[i].ActiveJob.Level + " " + 
					party[i].ActiveJob.JobName + " | XP: " + 
					party[i].ActiveJob.Experience.ToString() + "/" +
					party[i].ActiveJob.NextLevel.ToString() + " | G:" +
					party[i].EffectiveGuts.ToString() + " A:" +
					party[i].EffectiveAwesomeness.ToString()
					, guiStyle);
			}
		}

		private void HandleJobLevelEvent() {
			print ("LEVEL EVENT");
		}

		void InitializeCharacterObjects(List<BaseCharacterClass> characters) {
			foreach (BaseEntityClass entity in characters) {
				InitializeEntityObject (entity);
			}
		}

		void InitializeEnemyObjects(List<BaseEnemyClass> enemies) {
			foreach (BaseEntityClass entity in enemies) {
				InitializeEntityObject (entity);
			}
		}

		void InitializeEntityObject(BaseEntityClass entity) {
			GameObject entitySprite = new GameObject ();
			renderer = entitySprite.AddComponent<SpriteRenderer> ();
			entitySprite.GetComponent<SpriteRenderer> ().sprite = GetComponent<SpriteRenderer>().sprite = dictSprites[entity.TextureName];
			entitySprite.transform.position = entity.Position;
			entitySprite.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
			entity.EntityGameObject = entitySprite;
		}

		void AnimateDamage(BaseEntityClass entity) {
			iTween.ShakePosition (entity.EntityGameObject, iTween.Hash("x", 0.1f, "y", 0.1f, "time", 0.5f));
		}
	}
}
