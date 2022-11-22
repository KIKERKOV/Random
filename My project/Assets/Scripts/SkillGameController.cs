using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillGameController : MonoBehaviour
{


    public float _combatTime = 5;
    public void OnMouseDown()
    {
        Debug.Log("I was clicked");
        StartCoroutine(SkillCombatTimer());
    }

    private IEnumerator SkillCombatTimer()
    {
        yield return new WaitForSeconds(_combatTime);
        Debug.Log("Skill combat time expired");
    }

    public void CombatTimer()

    {
        // Count how much time has passed between combat 
        

        

    }    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
