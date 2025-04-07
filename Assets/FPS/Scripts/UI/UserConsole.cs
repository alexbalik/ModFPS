using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;

public class UserConsole : MonoBehaviour
{
    public GameObject userconsole;
    //Check if user presses the "~" key
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            //activeSelf is a Unity read-only property that returns whether the
            //object before the '.' is active or not. In the case below, check to
            //see if the user console is active. If it's true that the user console is
            //already active, return false so that SetActive() makes the user console
            //go away when '~' is pressed
            userconsole.SetActive(!userconsole.activeSelf);
        }

    }

    public TMP_InputField inputField;
    public TextMeshProUGUI sample;

    void HandleCommand()
    {
        if (inputField.text == "undamageable")
            sample.text = "Success";
    }


}
