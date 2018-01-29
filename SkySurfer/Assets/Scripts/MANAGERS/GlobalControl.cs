using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    bool easyMode;
    bool isUsingController;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start() {
        easyMode = false;
    }

    public void swapMode() {
        easyMode = !easyMode;
    }

    public bool getEasyMode() {
        return easyMode;
    }

    public void setIsUsingController(bool b) {
        isUsingController = b;
    }

    public bool getIsUsingController() {
        return this.isUsingController;
    }
}