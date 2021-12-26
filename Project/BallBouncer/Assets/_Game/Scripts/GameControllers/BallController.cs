using TMPro;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float HorizontalForceMin;
    public float HorizontalForceMax;

    public Rigidbody Rigid;
    public TextMeshProUGUI TextField;
    public GameObject DeathScreen;
    public Animator Animator;
    
    private int points;
    
    private void Start()
    {
        TextField.text = points.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        var randomForce = UnityEngine.Random.Range(HorizontalForceMin, HorizontalForceMax);

        Rigid.AddForce(new Vector3(randomForce, 0, 0), ForceMode.Impulse);

        if (other.collider.CompareTag("Player"))
        {
            points++;
            TextField.text = points.ToString();
            
            Animator.Play("Bounce");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            DeathScreen.SetActive(true);
        }
    }
}
