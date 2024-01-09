using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image SoundOnIcon;
    [SerializeField] Image SoundOffIcon;
    private bool mute = false;
    // Start is called before the first frame update
    void Start()
    {
         if(!PlayerPrefs.HasKey("mute")){
            PlayerPrefs.SetInt("mute", 0);
            Load();
         }

         else Load();

         UpdateIcon();
         AudioListener.pause = mute;
    }


    public void OnButtonPress(){
        if(mute == false){
            mute = true;
            AudioListener.pause = true;
        }
        else {
            mute = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateIcon();
    }
    private void UpdateIcon(){
        if(mute ==  false){
            SoundOnIcon.enabled = true;
            SoundOffIcon.enabled = false;
        }
        else {
            SoundOnIcon.enabled = false;
            SoundOffIcon.enabled = true;
        }
    }


    private void Load(){
        mute = PlayerPrefs.GetInt("mute") == 1;
    }
    private void Save(){
        PlayerPrefs.SetInt("mute", mute ? 1 : 0);
    }
    // Update is called once per frame
   
}
