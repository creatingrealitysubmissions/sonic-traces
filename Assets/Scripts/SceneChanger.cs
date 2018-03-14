using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour
{

    public int sceneNumber;
    public int seconds;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(seconds);
        Application.LoadLevel(sceneNumber);
    }

}