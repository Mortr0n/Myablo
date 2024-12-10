using UnityEngine;
using UnityEngine.Events;

public class EventsManager : MonoBehaviour
{
    public UnityEvent<float> onExperienceGranted;
    public UnityEvent<float> onExperienceUpdated;
    public UnityEvent<float> onHealthChanged;
    public UnityEvent<float> onManaChanged;
    public UnityEvent onPlayerDied;
    public UnityEvent onPlayerRevived;
    public UnityEvent onPlayerLeveledUp;

    public static EventsManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
}

