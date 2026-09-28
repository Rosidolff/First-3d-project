using UnityEngine;

public class HelloWorldUnity : MonoBehaviour
{
    [Header("Player Settings")] //para que aparezca un header en el inspector
     [Tooltip("This is the name of the player")] //para que aparezca un tooltip en el inspector
     [SerializeField] private string playerName; //para que siendo privado se pueda ver en el inspector
     [Tooltip("Enter the player's score")] 
     [Range(0, 100)] //delimito los valores de playerScore entre 0 y 100 (además pone un slider en el inspector)
     [SerializeField] private int playerScore;

    [HideInInspector] public bool isPlayer; //es publico pero no aparece en el inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello " + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
