using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lessontask_1
{
    public class Weapon
    {
        private int capacity;
        private int bulletsInComb;
        private string fireMode;

        public Weapon(int capacity, int bulletsInComb, string fireMode)
        {
            if (capacity <= 0 || bulletsInComb < 0 || bulletsInComb > capacity)
                throw new ArgumentException("Invalid capacity or number of bullets.");
            if (fireMode != "single" && fireMode != "triple" && fireMode != "automatic")
                throw new ArgumentException("Invalid fire mode. Use 'single', 'triple', or 'automatic'.");

            this.capacity = capacity;
            this.bulletsInComb = bulletsInComb;
            this.fireMode = fireMode;
        }

        public void Shoot()
        {
            if (bulletsInComb > 0)
            {
                bulletsInComb--;
                Console.WriteLine("Fired 1 bullet.");
            }
            else
            {
                Console.WriteLine("No bullets left in the comb!");
            }
        }

        public void Fire()
        {
            if (fireMode == "single")
            {
                Console.WriteLine("Firing all bullets one by one...");
                while (bulletsInComb > 0) Shoot();
            }
            else if (fireMode == "triple")
            {
                Console.WriteLine("Firing in burst mode...");
                for (int i = 0; i < 3 && bulletsInComb > 0; i++) Shoot();
            }
            else if (fireMode == "automatic")
            {
                Console.WriteLine("Firing all bullets in automatic mode...");
                while (bulletsInComb > 0) Shoot();
            }
        }

        public int GetRemainBulletCount()
        {
            return capacity - bulletsInComb;
        }

        public void Reload()
        {
            int bulletsNeeded = capacity - bulletsInComb;
            bulletsInComb = capacity;
            Console.WriteLine($"Reloaded {bulletsNeeded} bullets.");
        }

        public void ChangeFireMode()
        {
            if (fireMode == "single")
                fireMode = "triple";
            else if (fireMode == "triple")
                fireMode = "automatic";
            else if (fireMode == "automatic")
                fireMode = "single";

            Console.WriteLine($"Fire mode changed to {fireMode}.");
        }

        public void EditCapacity(int newCapacity)
        {
            if (newCapacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");
            capacity = newCapacity;
            if (bulletsInComb > capacity) bulletsInComb = capacity;
            Console.WriteLine($"Comb capacity changed to {newCapacity}.");
        }

        public void EditBullets(int newBullets)
        {
            if (newBullets < 0 || newBullets > capacity)
                throw new ArgumentException("Invalid bullet count.");
            bulletsInComb = newBullets;
            Console.WriteLine($"Bullets in comb set to {newBullets}.");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Capacity: {capacity}, Bullets in Comb: {bulletsInComb}, Fire Mode: {fireMode}");
        }
    }

}
