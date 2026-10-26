// //using UnityEngine;

// public class MovimientoNave : MonoBehaviour

// private Rigidbody2D rigidbody2D;
// {
//     public float velocidad = 5f;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         rigidbody2D = GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
//         {
//             rigidbody2D.AddForce(Vector2.up * fuerza * Time.deltaTime);
//         }

//         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
//         {
//             rigidbody2D.AddForce(Vector2.down * fuerza * Time.deltaTime);
//         }

//         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
//         {
//             rigidbody2D.AddForce(Vector2.left * fuerza * Time.deltaTime);
//         }

//         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
//         {
//             rigidbody2D.AddForce(Vector2.right * fuerza * Time.deltaTime);
//             spriteRenderer.color = Color.pink;
//         }
//     }
// }
// //