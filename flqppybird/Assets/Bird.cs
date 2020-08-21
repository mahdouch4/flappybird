
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
    bool shit;
    public GameObject ReplayButton;
    float score;
    bool Isdead;
    float x;
    public Text Score;
    public float movespeed = 80;
    public float jumpforce = 200.8f;
    private void Awake()
    {
        
    }
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (Vector3.right * movespeed) * Time.deltaTime;
        ReplayButton.SetActive(false);





    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Isdead)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpforce );
            GetComponent<Rigidbody2D>().velocity = (Vector3.right * movespeed) * Time.deltaTime;
            
 

        }
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Isdead = true;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Animator>().SetBool("Isdead", true);
            ReplayButton.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "f")
        {
            Isdead = true;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Animator>().SetBool("Isdead", true);
            ReplayButton.SetActive(true);
            Time.timeScale = 0;
        }
       



    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ff")
        {
            score++;
            Score.text = score.ToString("0");
        }
    }
    public void Replay()
    {
        
        SceneManager.LoadScene(0);
       
    }
   




}


