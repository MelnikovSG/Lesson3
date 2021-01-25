using UnityEngine;


namespace RollBall
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable
    {
        public bool IsInteractable { get; } = true;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Counter();
                Interaction();
                Destroy(gameObject);
            }
        }

        protected abstract void Interaction();

        protected abstract void Counter();
    }
}

