using UnityEngine;
using UnityEngine.UI;

public class MapCompletionProgress : MonoBehaviour
{
    public GameObject Player;
    public Text PercentageComplete;

    public Transform MapStartingPoint;
    public Transform MapEndingPoint;
 

    private float distanceToGoal;

    private void Start()
    {
        distanceToGoal = MapEndingPoint.position.y - MapStartingPoint.position.y;
        PercentageComplete.text = "this is my text";
        
    }

    private void Update()
    {
        float currentPlayerDistance = MapEndingPoint.position.x - Player.transform.position.y;
        float progress = 1.0f - (currentPlayerDistance / distanceToGoal);

        if (Player.transform.position.x > MapEndingPoint.position.y)
            progress = 1f;
        PercentageComplete.text ="dkshfvjhdbfipsb";

    }
}
