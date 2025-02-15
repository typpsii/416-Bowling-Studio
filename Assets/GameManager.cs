using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    private FallTrigger[] pins;

    private void Start()
    {
        pins = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include);

        foreach (FallTrigger pin in pins)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    private void IncrementScore()
    {
        score++;
    }
}
