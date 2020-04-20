using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class ReadWeatherXML : MonoBehaviour
{
    string key = "5ce4711625e2362ce6528583bed12e19";
    string apiReturn = "";
    public string cityName = "";
    public string windDirection = "";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetWeather());
        
    }
    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://api.openweathermap.org/data/2.5/weather?zip=10027&mode=xml&APPID=" + key);
            yield return www.SendWebRequest();

        if(!www.isNetworkError && !www.isHttpError)
        {
            //Get text content like this:
            Debug.Log(www.downloadHandler.text);
            apiReturn = www.downloadHandler.text;
        }
        else
        {
            Debug.Log(www.error + " " + www);
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if(apiReturn.Length != 0)
        {
            int tagForNameStart = apiReturn.IndexOf("name="+ 2); //This gets us the index of the n for the first time it finds "name="
            int tagForCityStart = tagForNameStart + 6;
            int tagForNameEnd = apiReturn.IndexOf("coord");
            int tagForCityEnd = tagForNameEnd - 3;

            cityName = apiReturn.Substring(tagForCityStart, tagForNameEnd - tagForCityStart);


            string everythingAfterWind = apiReturn.Substring(apiReturn.IndexOf("win"));
            string everythingAfterDirection = everythingAfterWind.Substring(apiReturn.IndexOf("direction"));
            int tagForNameStart = everythingAfterDirection.IndexOf("name=");

           
        }
    }
}
