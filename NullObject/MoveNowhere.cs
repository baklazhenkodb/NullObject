using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    /// <summary>
    /// Так называемый null-object,
    /// класс который реализует "отсутствие движения" - его можно использовать, например, для 
    /// первоначального создания экземпляра класса Ball, для последующей его настройки и отладки 
    /// </summary>
    class MoveNowhere: IMovement
    {
        public MoveNowhere()
        {

        }

        void IMovement.Move()
        {
            
        }
    }
}
