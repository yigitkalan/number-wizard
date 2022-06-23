using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Guessed : MonoBehaviour
{
    [SerializeField]TMP_Text countText;
    // Start is called before the first frame update
    void Start()
    {
        countText.text = $"I  guessed  it  in  {NumberWizard.getCount()} attempts !!";
       
    }

   
}
