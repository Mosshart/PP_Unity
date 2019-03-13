using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Login : MonoBehaviour
{

    InputField login;
    InputField password;
    public Canvas mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onLoginClick()
    {
        //todo database check
        if(login.text == "test" && password.text == "test")
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            mainCanvas.gameObject.SetActive(true);

        }
    }
}
