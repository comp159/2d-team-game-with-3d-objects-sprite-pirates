using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private PlayerController player;
    [SerializeField] private GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        player = character.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        player.UpdateHealthLabel();
        if (player.healthPoints <= 0)
        {
            player.GameOver();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
