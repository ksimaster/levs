using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ADScript : MonoBehaviour
{
	//public Slider sliderHome;
	//public Slider sliderFuelCar;
	//public float rewardBonusSliderHome;
	//public float rewardBonusSliderFuel;
	//public float lowBalanceFuel;

    public void ShareFriend(){
#if UNITY_WEBGL && !UNITY_EDITOR
        WebGLPluginJS.ShareFunction();
#endif
    }

    public void ShowAdInterstitial(){
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.InterstitialFunction();
#endif
    }

    public void ShowAdReward(){
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.RewardFunction();
#endif
       // sliderHome.value += rewardBonusSliderHome;
    	//if(sliderFuelCar.value<=lowBalanceFuel) sliderFuelCar.value += rewardBonusSliderFuel;
    }

    //Change language

    public void SetEnglish(string message)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.SetEnglishFunction(string message);
#endif
        PlayerPrefs.SetString("lang", message);
    }
    public void SetRussian(string message)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.SetRussianFunction(string message);
#endif
        PlayerPrefs.SetString("lang", message);
    }


    private void Update()
    {
        //if (sliderHome.value <= sliderHome.minValue) ShowAdInterstitial();
    }
}
