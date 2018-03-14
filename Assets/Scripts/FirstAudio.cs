using UnityEngine;
using Vuforia;

public class FirstAudio : MonoBehaviour, ITrackableEventHandler
{
    //public GameObject audio;
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource m_MyAudioSource;
    public AudioSource musicOne;
    public AudioSource musicTwo;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        //m_MyAudioSource = this.GetComponent<AudioSource>();
    }

    public void OnTrackableStateChanged(
    TrackableBehaviour.Status previousStatus,
    TrackableBehaviour.Status newStatus)
    {

        Debug.Log("State tracking change");
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            m_MyAudioSource.Play();
            musicOne.Play();
            musicTwo.Play();
        }
       
    }
}