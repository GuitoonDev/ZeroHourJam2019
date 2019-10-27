using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEventSystem : MonoBehaviour
{
	public Animation _anim;
	public GameManager gameManager;


	public void StartGame()
	{
		_anim.Play();
	}

	private void Ready()
	{
		gameManager._onBeingReady?.Invoke();
	}
}
