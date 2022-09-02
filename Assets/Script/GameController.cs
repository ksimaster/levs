using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public AudioSource monsterSound;
    public AudioSource voiceMonsterSound;
    public AudioSource backgoundSound;
    public AudioSource playerSound;

    private void Start()
    {

        

    }
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void PauseOn()
    {
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
    }
    public void SoundOn()
    {
        monsterSound.mute = false;
        voiceMonsterSound.mute = false;
        backgoundSound.mute = false;
        playerSound.volume = 1;
    }
    public void SoundOff()
    {
        monsterSound.mute = true;
        voiceMonsterSound.mute = true;
        backgoundSound.mute = true;
        playerSound.volume = 0;
    }
}
