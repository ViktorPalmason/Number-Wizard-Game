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
        guess = (max+min)/2;
        max++;
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        guess = (max + min) / 2; 
        guessText.text = guess.ToString();
    }

    public void OnPressLower()
    {
        max = guess;
        guess = (guess + min) / 2;
        guessText.text = guess.ToString();
    }
}
