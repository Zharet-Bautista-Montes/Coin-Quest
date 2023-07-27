using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //La primera posición del arreglo se deja en 0,
	//el resto guarda el puntaje según el nivel. 
	public static int[] scoreList = new int[4];
	public TMP_Text scoreText;
	private static int currentIndex;
	
    public static void SumScore()
    {
        scoreList[currentIndex] += 1;
    }
	
	public static void resetScore()
	{
		for(int u = 0; u < scoreList.Length; u++)
			scoreList[u] = 0;
	}
	
	public static int getFinalScore()
	{
		int total = 0;
		for(int u = 0; u < scoreList.Length; u++)
			total += scoreList[u];
		return total;
	}

    public void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentIndex < scoreList.Length) 
			scoreList[currentIndex] = 0;
    }

    public void Update()
	{
		currentIndex = SceneManager.GetActiveScene().buildIndex;
		if(currentIndex < scoreList.Length)
			scoreText.text = "X " + scoreList[currentIndex];
		else scoreText.text = "Final Score: " + getFinalScore();
	}
}