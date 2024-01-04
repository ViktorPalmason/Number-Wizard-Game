using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    [SerializeField] TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess-1;

        NextGuess();
    }

    private void NextGuess()
    {
        //guess = (guess + min) / 2;
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }
}
