using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static int argent;
	public int startMoney = 600;

	public static int Vies;
	public int startLives = 15;

	public static int Rounds;

	void Start()
	{
		argent = startMoney;
		Vies = startLives;

		
	}
}
