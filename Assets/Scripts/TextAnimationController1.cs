using UnityEngine;

public class TextAnimationController1 : MonoBehaviour {

    Animation anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
        anim.Play();
        anim.Stop();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
