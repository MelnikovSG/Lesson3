using UnityEngine.Events;


namespace RollBall
{
    public sealed class GoodBonus : InteractiveObject
    {
        private DisplayBonuses _displayBonuses;
        int count = 0;
        public UnityEvent HitEvent;

        public void Awake()
        {
            _displayBonuses = new DisplayBonuses();
        }

        protected override void Interaction()
        {
            _displayBonuses.Display(count);
            HitEvent.Invoke();
        }

        protected override void Counter()
        {
            count++;
        }
    }
}

