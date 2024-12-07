namespace lessontask_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Create Your Weapon ===");
            Console.Write("Enter comb capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Enter bullets in comb: ");
            int bulletsInComb = int.Parse(Console.ReadLine());
            Console.Write("Enter fire mode (single/triple/automatic): ");
            string fireMode = Console.ReadLine();

            Weapon weapon = new Weapon(capacity, bulletsInComb, fireMode);

            while (true)
            {
                Console.WriteLine("\n=== Options ===");
                Console.WriteLine("0 - Get Information");
                Console.WriteLine("1 - Shoot");
                Console.WriteLine("2 - Fire");
                Console.WriteLine("3 - Get Remaining Bullet Count");
                Console.WriteLine("4 - Reload");
                Console.WriteLine("5 - Change Fire Mode");
                Console.WriteLine("6 - Quit");
                Console.WriteLine("7 - Edit Options");
                Console.WriteLine("  8 - Change Comb Capacity");
                Console.WriteLine("  9 - Change Number of Bullets in Comb");

                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        weapon.GetInfo();
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine($"Bullets needed to fill the comb: {weapon.GetRemainBulletCount()}");
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    case 7:
                        Console.WriteLine("\n=== Edit Options ===");
                        Console.WriteLine("8 - Change Comb Capacity");
                        Console.WriteLine("9 - Change Number of Bullets in Comb");
                        Console.Write("Choose an edit option: ");
                        int subChoice = int.Parse(Console.ReadLine());
                        if (subChoice == 8)
                        {
                            Console.Write("Enter new comb capacity: ");
                            int newCapacity = int.Parse(Console.ReadLine());
                            weapon.EditCapacity(newCapacity);
                        }
                        else if (subChoice == 9)
                        {
                            Console.Write("Enter new number of bullets in comb: ");
                            int newBullets = int.Parse(Console.ReadLine());
                            weapon.EditBullets(newBullets);
                        }
                        else
                        {
                            Console.WriteLine("Invalid edit option.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}