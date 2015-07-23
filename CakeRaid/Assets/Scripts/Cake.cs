using UnityEngine;
using System.Collections;

namespace CakeRaid{
	public class Cake : MonoBehaviour {
		//GameObject cursor;

		public Texture2D cursorTexture;
		public CursorMode cursorMode;
		public Vector2 hotSpot;

		// Use this for initialization
		void Start () {
			cursorTexture = Resources.Load<Texture2D>("Textures/Cursor");
			cursorMode = CursorMode.Auto;
			hotSpot = Vector2.zero;


		}
		
		// Update is called once per frame
		void Update () {
			
		}
			
		void OnMouseEnter () {
			Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		}

		void OnMouseExit () {
			Cursor.SetCursor(null, Vector2.zero, cursorMode);
		}
	}
}