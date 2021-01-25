using UnityEngine;


namespace RollBall
{
    public class Trycatch : Player
    {
        // хитрый геймдиз выдумал badbonus в виде /10 скорости персонажа при подборе не верного интерактивного объекта.
        // однако промахнулся клавишей и выдал в задаче /0 из-за чего может возникнуть ошибка в исполнении программы.
        // обработаем исключение.

        void TryCatch()
        {
            try
            {
                float i = GetComponent<Player>().speed;
                i = i / 0;
                Debug.Log("скорость персонажа равна " + i);
            }
            catch
            {
                Debug.Log("Возникло исключение");
            }
            finally
            {
                Debug.Log("Делить на ноль нельзя");
            }
        }
    }
}
