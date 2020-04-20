using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    public char myChar;
    public string myString;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(myChar);
        //Debug.Log(myString);
        //Debug.Log(myChar + " " + myString);
        //Debug.Log(myString.Substring(3));
        //Debug.Log(myString.Substring(3, 1));
        //Debug.Log(myString);
        //Debug.Log(myString.ToUpper());
        //Debug.Log(myString.ToLower());
        string lowerCaseVersionOfMyString = myString.ToLower();

        if (lowerCaseVersionOfMyString.IndexOf(" is ") != -1)

            Debug.Log(myString.IndexOf(" is "));
        else if (lowerCaseVersionOfMyString.IndexOf(" is, ") != -1)
            Debug.Log(lowerCaseVersionOfMyString.IndexOf(" is, "));
        else if (lowerCaseVersionOfMyString.IndexOf(" is. ") != -1)
            Debug.Log(lowerCaseVersionOfMyString.IndexOf(" is. "));
       



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
