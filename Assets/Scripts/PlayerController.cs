using TMPro;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject EndGame;
    [SerializeField] private GameObject GameOverButton;
    [SerializeField] private TextMeshProUGUI HealthPointTotal;
    private string prefix = "Health: ";
    private int healthPoints = 100;

    void Start()
    {
        
    }

    void Update()
    {
    HandleMovementInput();
    UpdateHealthLabel();
    
        if (healthPoints == 0)
        {
            GameOver();
        }
    }

    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }

    void LoseHP()
    {
        healthPoints -= 20;
        Debug.Log(healthPoints);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            LoseHP();
        }
    }

    void GameOver()
    {
        
        Destroy(this.gameObject);
        EndGame.SetActive(true);
        GameOverButton.SetActive(true);
    }

    void UpdateHealthLabel()
    {
        HealthPointTotal.SetText(prefix + healthPoints);
    }
    
}