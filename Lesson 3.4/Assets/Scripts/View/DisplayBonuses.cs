using System;
using UnityEngine;
using UnityEngine.UI;


namespace RollBall
{
    public sealed class DisplayBonuses
    {
        private Text _bonuseLable;
        public DisplayBonuses(GameObject bonus)
        {
            _bonuseLable = bonus.GetComponentInChildren<Text>();
            _bonuseLable.text = String.Empty;
        }

        public void Display(int value)
        {
            Debug.Log("Вы набрали " + value);
        }
    }
}
