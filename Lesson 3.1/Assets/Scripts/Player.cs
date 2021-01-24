using UnityEngine;


namespace RollBall
{
    public class Player : MonoBehaviour
    {
        public float speed = 3.0f;
        private Rigidbody _rigidbody;

        private string _horizontal = "Horizontal";
        private string _vertical = "Vertical";

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis(_horizontal);
            float moveVertical = Input.GetAxis(_vertical);

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Buster"))
            {
                speed += 1;
            }else if (other.CompareTag("Trap"))
            {
                Destroy(gameObject);
            }
        }
    }

    
}
