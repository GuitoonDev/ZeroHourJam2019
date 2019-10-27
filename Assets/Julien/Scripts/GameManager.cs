using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
	public CharacterEventSystem character;
	private bool _gameStarted;
	public UnityEvent _onBeingReady;
	public GameObject openingScreen;


	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (!_gameStarted)
			{
				character.StartGame();
				_gameStarted = true;
				openingScreen.SetActive(false);
			}
		}
	}
}
