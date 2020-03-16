using System;

namespace NullObject
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу,
        /// создание экземпляра класса Ball и иллюстрация 
        /// стратегии поведения при движении
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Ball RedBall=new Ball(new MoveUp());
            RedBall.Move = new MoveNowhere();
            RedBall.Move.Move();

            Console.ReadKey();
        }
    }
}
