using UnityEngine;
using Vuforia;

public class AnimationQR : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour QrTrak;
    // Start is called before the first frame update
    void Start()
    {
        QrTrak = GetComponent<TrackableBehaviour>();
        if (QrTrak)
            QrTrak.RegisterTrackableEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus
        )
    {
        Animator[] animations = GetComponentsInChildren<Animator>();
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            foreach (Animator comp in animations)
                comp.enabled = true;
        }
        else
        {
            foreach (Animator comp in animations)
            {
                comp.Rebind();
                comp.enabled = false;
            }
        }
    }
}
