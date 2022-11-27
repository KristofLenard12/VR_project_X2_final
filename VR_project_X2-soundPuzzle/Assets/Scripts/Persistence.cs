using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//contains all code stuff needed to persist between scenes
public class Persistence : MonoBehaviour
{
    public static Persistence Instance;
    public static OVRScreenFade sceneFader;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        sceneFader = gameObject.AddComponent<OVRScreenFade>();
    }
}
