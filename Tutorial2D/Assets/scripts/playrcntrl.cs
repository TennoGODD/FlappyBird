using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playrcntrl : MonoBehaviour
{

    public static playrcntrl instats;
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    private int score = 0;

    public TextMeshProUGUI textScore;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
     
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            rb.AddForce((transform.up*jumpForce),ForceMode2D.Impulse);
    }


    public void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "PipePart")
            GameManager.instance.Lose();
        if(other.gameObject.tag == "trigger")
        {
            score++;
            textScore.text = "Score: "+ score;
        }
    }

    
    
}
