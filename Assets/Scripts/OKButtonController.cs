using UnityEngine;

public class OKButtonController : MonoBehaviour
{

    public int sceneNumber;

    public void ButtonIsClicked()
    {
        Application.LoadLevel(sceneNumber);
    }
}