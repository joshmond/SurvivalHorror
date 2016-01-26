using UnityEngine;
using System.Collections;

public class PlayerCondition : MonoBehaviour 
{
	private float CurrentHealth {get; set;}
	private float MaxHealth {get; set;}
	private float CurrentStamina {get; set;}
	private float MaxStamina {get; set;}
	private float CurrentHunger {get; set;}
	private float MaxHunger {get; set;}
	private float CurrentSanity {get; set;}
	private float MaxSanity {get; set;}
	private float CurrentStress {get; set;}
	private float MaxStress {get; set;}
	private int Score {get; set;}
	
	public void GainHealth(float amount)
	{
		CurrentHealth += amount;

		if(CurrentHealth >= MaxHealth)
		{
			CurrentHealth = MaxHealth;
		}
	}

	public void LoseHealth(int amount)
	{
		CurrentHealth -= amount;
		
		if(CurrentHealth <= 0.0f)
		{
			CurrentHealth = 0.0f;
		}
	}

	public void Stamina(float amount)
	{
		if(CurrentStamina != MaxStamina)
		{
			CurrentHealth += amount;
		}
		else
		{
			CurrentStamina = MaxStamina;
		}
	}

	public void SatisfyHunger(float amount)
	{
		CurrentHealth += amount;

		if(CurrentHunger >= MaxHunger)
		{
			CurrentHunger = MaxHunger;
		}
	}

	public void GainHunger(float amount)
	{
		CurrentHealth -= amount;
		
		if(CurrentHunger <= 0.0f)
		{
			CurrentHunger = 0.0f;
		}
	}

	public void GainSanity(float amount)
	{
		CurrentSanity += amount;

		if(CurrentSanity >= MaxSanity)
		{
			CurrentSanity = MaxSanity;
		}
	}

	public void LoseSanity(float amount)
	{
		CurrentSanity -= amount;
		
		if(CurrentSanity >= 0.0f)
		{
			CurrentSanity = 0.0f;
		}
	}


	public void GainStress(float amount)
	{
		CurrentStress += amount;
		
		if(CurrentStress >= MaxStress)
		{
			CurrentStress = MaxStress;
		}
	}
	
	public void LoseStress(float amount)
	{
		CurrentStress -= amount;
		
		if(CurrentStress >= 0.0f)
		{
			CurrentStress = 0.0f;
		}
	}

	public void GainScore(int amount)
	{
		Score += amount;
	}


}
