using System;

namespace Hierarchical_Inheritance
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog();
            sharo.Eat();
            sharo.Bark();

            Cat maca = new Cat();
            maca.Eat();
            maca.Meow();
        }
    }
}
