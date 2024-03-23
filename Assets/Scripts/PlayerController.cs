using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        public float speed = 100f; // Velocidad de movimiento
        public float rotationSpeed = 100f; // Velocidad de rotación
        public float gravity = 240f; // Control de fuerza de la gravedad
        private CharacterController controller; // Referencia al CharacterController
        void Start()
        {
            // Obtener la referencia al CharacterController
            controller = GetComponent<CharacterController>();
        }
        void Update()
        {
            // Obtener la entrada del jugador (izquierda y derecha)
            float horizontal = Input.GetAxis("Horizontal");
            // En un mundo tridimensional, las flechas arriba y abajo se
            // interpretan como hacia delante y hacia atrás
            float vertical = Input.GetAxis("Vertical");
            // Aplicamos la gravedad si no está en el suelo
            if (!controller.isGrounded)
            {
                Vector3 descenso = Vector3.down;
                descenso.y = descenso.y * gravity * Time.deltaTime;
                controller.Move(descenso);
            }
            // Rotamos el personaje en base al Input Horizontal
            transform.Rotate(transform.up * horizontal * rotationSpeed * Time.deltaTime);

            // Movemos el personaje en base al Input Vertical
            controller.Move(transform.forward * vertical * speed * Time.deltaTime);
        }
    }