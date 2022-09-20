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

    public void SetEnglish()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.SetEnglishFunction();
#endif
        PlayerPrefs.SetString("lang", "en");
    }
    public void SetRussian()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    	WebGLPluginJS.SetRussianFunction();
#endif
        PlayerPrefs.SetString("lang", "ru");
    }


    private void Update()
    {
        //if (sliderHome.value <= sliderHome.minValue) ShowAdInterstitial();
    }
}
