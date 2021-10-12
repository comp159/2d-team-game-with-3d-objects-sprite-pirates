using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject EndGame;
    [SerializeField] private GameObject RestartButton;
    [SerializeField] private GameObject GameOverButton;
    [SerializeField] private TextMeshProUGUI HealthPointTotal;
    private Rigidbody rigbody;
    private CapsuleCollider capcollider;
    private int itemsCollected;
    [SerializeField] private GameObject winImage;
    private string prefix = "Health: ";
    public int healthPoints = 100;

    void Start()
    {
        rigbody = GetComponent<Rigidbody>();
        capcollider = GetComponent<CapsuleCollider>();
        itemsCollected = 0;
        winImage.gameObject.SetActive(false);
    }

    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }

    public void LoseHP()
    {
        healthPoints -= 20;
        Debug.Log(healthPoints);
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("HELLO");
        if (other.gameObject.tag == "Zombie")
        {
            LoseHP();
            healthPoints += 10;
        }
        
    }
    
    public void GameOver()
    {
        Destroy(this.gameObject);
        EndGame.SetActive(true);
        GameOverButton.SetActive(true);
    }
    
   
   public void UpdateHealthLabel()
   {
       HealthPointTotal.SetText(prefix + healthPoints);
   }

   public void CollectedItem()
   {
       itemsCollected++;
       if (NumItemsCollected() == 1)
       {
           winImage.gameObject.SetActive(true);
           RestartButton.gameObject.SetActive(true);
       }
   }

   public int NumItemsCollected()
   {
       return itemsCollected;
   }
}