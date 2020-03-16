using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    /// <summary>
    /// Класс, отвечающий за объект мяча,
    /// имитирующий его поведение и свойства
    /// </summary>
    class Ball
    {
       
        public IMovement Move;

        public Ball(IMovement move)
        {
            try
            {
                Move = move;
            }
            catch (Exception ex)
            {
                throw new Exception("Неверный обьект для класса движения");
            }
        }



    }
}
