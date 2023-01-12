using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    static BGM instance;
    // On met le .mp3 dans le "AudioClip"
    public AudioClip[] Music;
    // On met la source audio VIDE dedans, comme �a les Mp3 de Music vont dedans
    public AudioSource Audio;

    // Ca garde en vie entre toutes les sc�nes
    void Awake()
    {
        if (instance == null) { instance = this; }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += MusicSwitch;
    }
        
    // �a l'appelle a chaque fois qu'une sc�ne change
    void MusicSwitch(Scene scene, LoadSceneMode sceneMode)
    {
        // Variable de remplacement 
        AudioClip clip;

        // Joue une musique diff�rente a chaque sc�ne
        switch (scene.name)
        {
            case "Level01":
                clip = Music[0];
                break;
            default:
                clip = Music[0];
                break;
        }

        // Switch seulement si la musique change
        if (clip != Audio.clip)
        {
            Audio.enabled = false;
            Audio.clip = clip;
            Audio.enabled = true;
        }
    }
}