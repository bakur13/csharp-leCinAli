using System;

class Program
{
    static void Main(string[] args)
    {
        
      
        int r = 8;

        // Çemberin merkezi, x = r ve y = r koordinatında olsun
        for (int y = 0; y <= 2 * r; y++)
        {
            for (int x = 0; x <= 2 * r; x++)
            {
                // Eğer (x - r)² + (y - r)² <= r² ise, o nokta çemberin içindedir
                // Ayrıca, (x - r)² + (y - r)² >= (r - 1)² ise, o nokta da çemberin içindedir
                if ((x - r) * (x - r) + (y - r) * (y - r) <= r * r && (x - r) * (x - r) + (y - r) * (y - r) >= (r - 1) * (r - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
