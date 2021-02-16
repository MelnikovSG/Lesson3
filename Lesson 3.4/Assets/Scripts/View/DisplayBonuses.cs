using System;
using UnityEngine;
using UnityEngine.UI;


namespace RollBall
{
    public sealed class DisplayBonuses
    {
        private DisplayBonuses _displayBonuses;
        private Reference _reference;

        private Text _bonuseLable;
        public DisplayBonuses(GameObject bonus)
        {
            _bonuseLable = bonus.GetComponentInChildren<Text>();
            _bonuseLable.text = String.Empty;
        }

        public void CreateDisplay()
        {
            _displayBonuses = new DisplayBonuses(_reference.Bonuse);
            _reference.Bonuse.gameObject.SetActive(true);
        }

        public void Display(int value)
        {
            Debug.Log("Вы набрали " + value);
        }
    }
}
