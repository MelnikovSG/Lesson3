using UnityEngine.Events;


namespace RollBall
{
    public sealed class GoodBonus : InteractiveObject, IFlay, IFlicker
    {
        private Material _material;
        private float _lengthFlay;
        
        private DisplayBonuses _displayBonuses;
        int count = 0;
        public UnityEvent HitEvent;

        public void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);

            _displayBonuses = new DisplayBonuses();
        }

        protected override void Interaction()
        {
            _displayBonuses.Display(count);
            HitEvent.Invoke();
        }
        
         public void Flay()
        {
                transform.localPosition = new Vector3(transform.localPosition.x, 
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }
        
        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }


        protected override void Counter() // вывести в отдельный класс
        {
            count++;
        }
    }
}

