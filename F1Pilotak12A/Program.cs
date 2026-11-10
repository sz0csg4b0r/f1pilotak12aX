using F1Pilotak12A.Model;

namespace F1Pilotak12A
{
    internal class Program
    {
        public static List<Pilota> pilotak = new List<Pilota>();
        
        
        static void Main(string[] args)
        {
            Beolvasas("pilotak.csv");
            MennyiadatSor(pilotak);
            UtolsoPilotaAdata(pilotak);
        }

        private static void UtolsoPilotaAdata(List<Pilota> pilotak)
        {
            Console.WriteLine($"2. feladat: Listában az utolsó pilóta " +
                $"adatainak kiirása\n\t{pilotak[^1]}"  );
        }

        private static void MennyiadatSor(List<Pilota> pilotak)
        {
            Console.WriteLine($"1. feladat: Pilóták száma\n\tA fájlban összesen {pilotak.Count} pilóta adata található");
        }

        private static void Beolvasas(string v)
        {
            try
            {
                using (StreamReader reader = new StreamReader(v))
                {
                    // adatkezelő sor definiálás
                    string line;
                    if ((line = reader.ReadLine()) == null)
                    {
                        Console.WriteLine("A fájl üres vagy nincs fejléc...");
                        return;
                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        string [] parts = line.Split(';');
                        if (parts.Length==4)
                        {
                            Pilota pilota = new Pilota();
                            pilota.Nev = parts[0];
                            pilota.Szuldatum= parts[1];
                            pilota.Nezmetiseg = parts[2];
                            pilota.Rajtszam = parts[3];

                            pilotak.Add(pilota);

                        }
                        else
                        {
                            Console.WriteLine("Hibás sor formátum.");
                        }

                    }
                }
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine($"A fájl nem található: {error.Message}");
            }
            catch (IOException error)
            {
                Console.WriteLine($"IO error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Általános error: {error.Message}");
            }
        }
    }
}
