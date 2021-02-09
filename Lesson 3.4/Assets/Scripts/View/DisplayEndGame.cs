using System;
using UnityEngine;
using UnityEngine.UI;


namespace RollBall
{
    public sealed class DisplayEndGame
    {
        private DisplayEndGame _displayEndGame;
        private Reference _reference;

        private Text _finishGameLabel;

        public DisplayEndGame(GameObject endGame)
        {
            _finishGameLabel = endGame.GetComponentInChildren<Text>();
            _finishGameLabel.text = String.Empty;
        }

        public void DisplayOn()
        {
            _displayEndGame = new DisplayEndGame(_reference.EndGame);
        }


        public void GameOver(string name, Color color)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {name} {color} цвета";
        }
    }
}
