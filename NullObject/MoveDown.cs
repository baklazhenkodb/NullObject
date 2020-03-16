using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    /// <summary>
    /// Класс, реализующий движение объекта вниз
    /// </summary>
    class MoveDown: IMovement
    {
        public MoveDown()
        {

        }

        void IMovement.Move()
        {
            Console.WriteLine("Ball -> MoveDown");
        }
    }
}
