using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text descriptiveText;

    // Start is called before the first frame update
    void Start()
    {
        descriptiveText.text = string.Empty;
        CooldownTimer();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CooldownTimer()
    {
        descriptiveText.text = "Jadi kur";
    }


}
