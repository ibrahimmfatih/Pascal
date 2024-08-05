using System;

class Pascal
{
    static void Main()
    {
        Console.Write("Lütfen üçgenin kaç satır içereceğini giriniz >> ");
        int satir;

        // Kullanıcı geçerli bir input girene kadar döngü içinde kal
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out satir) && satir > 0)
            {
                break; // Geçerli input alındı, döngüden çık
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin.");
                Console.Write("Lütfen üçgenin kaç satır içereceğini giriniz >> ");
            }
        }

        // Pascal üçgenini oluşturma
        int[,] pascalucgeni = new int[satir, satir];
        
        for (int i = 0; i < satir; i++)
        {
            // İlk ve son elemanlar her zaman 1'dir
            pascalucgeni[i, 0] = 1;
            pascalucgeni[i, i] = 1;

            // İç kısımları hesapla
            for (int j = 1; j < i; j++)
            {
                pascalucgeni[i, j] = pascalucgeni[i - 1, j - 1] + pascalucgeni[i - 1, j];
            }
        }

        // Pascal üçgenini ekrana yazdırma
        Console.WriteLine("Pascal Üçgeni:");
        for (int i = 0; i < satir; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(pascalucgeni[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
