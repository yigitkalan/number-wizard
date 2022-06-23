using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int min = 1;
    [SerializeField]int max = 1000;
    static int count;
    [SerializeField]TMP_Text textComponent;
    int guess;

    void Start()
    {
        count = 1;
        guess = nextGuess();
        textComponent.text = $"is it {guess} ?";
    }

    public void Higher()
    {
        if (min == max)
            min = guess;
        else
        {
            min = guess + 1;
            count++;
        }

        guess = nextGuess();
        textComponent.text = $"is it {guess} ?";
    }

    public void Lower()
    {
        if (min == max)
            max = guess;
        else
        {
            max = guess - 1;
            count++;
        }

        guess = nextGuess();
        
        textComponent.text = $"is it {guess} ?";
    }

    public int nextGuess()
    {
        guess = Random.Range(min, max);
        return guess;
    }

    public static int getCount()
    {
        return count;
    }
}
