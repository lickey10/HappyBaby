﻿using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour {

	/// <summary>
	/// Singleton
	/// </summary>
	public static SoundEffectsHelper Instance;
	
	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;
	public AudioClip gameOverSound;
	public AudioClip youWonSound;
	public AudioClip[] levelCompleteSounds;
	public AudioClip levelEndedSound;
	public AudioClip levelLockedSound;
	public AudioClip levelStartedSound;
	public AudioClip[] bubblePoppingSounds;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	public void MakeExplosionSound()
	{
		MakeSound(explosionSound);
	}
	
	public void MakePlayerShotSound()
	{
		MakeSound(playerShotSound);
	}
	
	public void MakeEnemyShotSound()
	{
		MakeSound(enemyShotSound);
	}

	public void MakeGameOverSound()
	{
		MakeSound(gameOverSound);
	}

	public void MakeYouWonSound()
	{
		MakeSound(youWonSound);
	}

	public void MakeLevelCompleteSound()
	{
		MakeSound(levelCompleteSounds[Random.Range(0,levelCompleteSounds.Length)]);
	}

	public void MakeLevelEndedSound()
	{
		MakeSound(levelEndedSound);
	}

	/// <summary>
	/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
	
	public void MakeLevelStartedSound()
	{
		MakeSound(levelStartedSound);
	}

	public void MakeLevelLockedSound()
	{
		MakeSound(levelLockedSound);
	}

	public void MakeBubblePoppingSound()
	{
		MakeSound(bubblePoppingSounds[Random.Range(0,bubblePoppingSounds.Length)]);
	}
}
