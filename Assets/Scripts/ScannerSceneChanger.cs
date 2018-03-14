using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ScannerSceneChanger : MonoBehaviour
{

    public int sceneNumber;
    public int seconds;

    AudioSource audioSourceOne;

    void Start()
    {
        audioSourceOne = GetComponent<AudioSource>();
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(seconds);
        Application.LoadLevel(sceneNumber);
    }

    private void Update()
    {
        if (audioSourceOne.isPlaying)
        {
            StartCoroutine(Example());
        }
    }
}