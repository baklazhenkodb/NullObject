using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    /// <summary>
    /// Интерфейс IMovement будет реслизовывать какое-либо движение
    /// обьектов, например, движения вверх/прямо/Не двигаться
    /// </summary>
    interface IMovement
    {
        public void Move();
    }
}
