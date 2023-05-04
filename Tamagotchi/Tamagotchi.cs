using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    class Tamagotchi
    {
        private int hunger;
        private int happiness;
        private int energy;
        public Tamagotchi(int hunger, int happiness, int energy)
        {
            this.hunger = hunger;
            this.happiness = happiness;
            this.energy = energy;
        }

        public void Feed()
        {
            Console.WriteLine("Кормим тамагочи...");
            hunger--;
            happiness++;
        }

        public void Play()
        {
            Console.WriteLine("Играем с тамагочи...");
            happiness++;
            energy--;
        }

        public void Sleep()
        {
            Console.WriteLine("Укладываем тамагочи спать...");
            energy++;
            hunger++;
        }

        public void CheckStatus()
        {
            Console.WriteLine("Состояние Тамагочи:");
            Console.WriteLine("Голод: " + hunger);
            Console.WriteLine("Счастье: " + happiness);
            Console.WriteLine("Энергия: " + energy);
        }
    }
}
