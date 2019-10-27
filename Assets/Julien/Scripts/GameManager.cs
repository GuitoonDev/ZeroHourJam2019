using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
	public CharacterEventSystem character;
	private bool _gameStarted;
	public UnityEvent _onBeingReady;


	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !_gameStarted)
		{
			character.StartGame();
		}
	}
}
