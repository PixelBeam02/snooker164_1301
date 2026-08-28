using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int Playerscore;

    public int PlayerScore { get { return Playerscore; } set { Playerscore = value; } }
    public static GameManager instance;

    void awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
