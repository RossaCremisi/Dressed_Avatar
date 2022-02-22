using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class User : MonoBehaviour
{
    public static InputField inputTextField;
    public Text Not;
    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

   public void CheckUserNameAndLoadScene()
    {
        switch (inputTextField.text)
        {
            case "Marco":

                SceneManager.LoadScene("LoadingScene");
                break;

            case "Gatto":

                SceneManager.LoadScene("LoadingScene");
                break;

            default:
                inputTextField.text = "";
            
               
                Debug.Log("You can t pass");
                break;
        }
    }
    void Update()
    {
        
    }
}
