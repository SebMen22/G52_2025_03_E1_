using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float Globaltime = 0;

    public float Globaltime1 { get => Globaltime; set => Globaltime = value; }

    private void awake() 
    {
        if (Instance != null && Instance != this) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    
    }

   

    public void SumaTimeGlobal(float timeScene)
    { 
    
    }
}
