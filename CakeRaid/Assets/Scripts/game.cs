using UnityEngine;
using System.Collections;

namespace CakeRaid{
	public class Game : MonoBehaviour {
		//GameObject cursor;

		// Use this for initialization
		void Start () {
			//cursor = GameObject.FindWithTag("cursor");
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		/*Texture2D cursorTexture = Resources.Load<Texture2D>("Cursor");
		CursorMode cursorMode = CursorMode.Auto;
		Vector2 hotSpot = Vector2.zero;
		void OnMouseEnter () {
			Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		}
		void OnMouseExit () {
			Cursor.SetCursor(null, Vector2.zero, cursorMode);
		}*/
	}
}