using UnityEngine;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public UnityEvent OnPinFall = new();
    public bool isPinFallen = false;
    public void OnTriggerEnter(Collider body)
    {
        if (body.CompareTag("Ground") && !isPinFallen)
        {
            isPinFallen = true;
            OnPinFall?.Invoke();
            Debug.Log("LOL");
        }
        
    }
}
