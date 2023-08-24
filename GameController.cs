using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    //So you can write the the debugger screen
    public TextMeshPro debuggerText;

    //So you can get user inputs
    public InputReader inputs;

    public Transform rh;
    public Transform lh;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Clear the debugger screen when user presses B button
        if (inputs.ButtonBDown)
        {
            debuggerText.SetText("Debugger Log (Press B to clear):");
        }

        //reload the scene if the user presses x
        if(inputs.ButtonXDown)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

    }

    
}
