using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
   [Header("Variables")]
    [SerializeField]private float jumpForce = 10f; // Fuerza del salto
    

    [Header("References")]
    [SerializeField]private Rigidbody2D rb;       // Para manejar físicas
    [SerializeField]private TextMeshProUGUI keyDisplayText; // Mostrar Tecla por Pantalla
    [SerializeField]private Animator PlayerAnimator;

    public Action OnCollisionDetected { get; set; }
    public Action PauseGame { get; set; }
    
    public Action AddPoint { get; set; }

    private bool isGrounded;      // Verifica si el jugador está en el suelo
    private KeyCode currentKey;   // Tecla actual generada
    private System.Random random; // Generador de teclas aleatorias
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        random = new System.Random();
        GenerateNewKey(); // Generar la primera tecla
    }

    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        // Verificar si la tecla correcta fue presionada y el jugador está en el suelo
        if (Input.GetKeyDown(currentKey) && isGrounded)
        {
            Jump();
            GenerateNewKey();
        }

         if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Tecla Escape pulsada");
            PauseGame?.Invoke();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void GenerateNewKey()
    {
        // Generar una tecla aleatoria (a-z)
        int randomKeyIndex = random.Next(0, 26); 
        currentKey = (KeyCode)((int)KeyCode.A + randomKeyIndex); //Convierte el valor de KeyCode.A a su valor numérico en la tabla ASCII

        // Mostrar la tecla generada en pantalla (puedes usar UI)
        if (keyDisplayText != null)
        {
            keyDisplayText.text = Convert.ToString(currentKey);
        }
        else
        {
            Debug.LogError("Referencia al texto de la UI no asignada.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag=="AddPoint")
        {
            AddPoint?.Invoke();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el jugador toca el suelo
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            PlayerAnimator.SetBool("IsGrounded",true);
        }

        if (collision.collider.CompareTag("Obstacle"))
        {
        Debug.Log("¡Has chocado con un obstáculo!");
            OnCollisionDetected?.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Verificar si el jugador dejó de tocar el suelo
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
            PlayerAnimator.SetBool("IsGrounded",false);
        }
    }

   
}
