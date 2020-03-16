using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{ 
    /// <summary>
    /// Класс реализующий движение обьекта вверх
    /// </summary>
    class MoveUp: IMovement
    {
      
        public  MoveUp()
        {
   
        }

         void IMovement.Move()
        {
            Console.WriteLine("Ball -> MoveUp");
        }
    }
}
