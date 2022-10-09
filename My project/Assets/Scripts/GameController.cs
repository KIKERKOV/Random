using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject rock;
    public GameObject paper;
    public GameObject scissors;

    public void GenerateAction()
    {
        int action = Random.RandomRange(0, 3);
        if (action==0)
        {
            rock.active = true;
            paper.active = false;
            scissors.active = false;
        }
        else if (action==1)
        {
            rock.active = false;
            paper.active = true;
            scissors.active = false;
        }
        else
        {
            rock.active = false;
            paper.active = false;
            scissors.active = true;
        }
        Debug.Log("Generate Action!!!");

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
