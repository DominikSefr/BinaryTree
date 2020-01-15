using System;

namespace BinarniStrom
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList<Applicant> applications = new SimpleLinkedList<Applicant>();
            applications.Add(new Applicant { Id = 520, Score = 50, RealName = "Jiří Vokurka" });
            applications.Add(new Applicant { Id = 415, Score = 61, RealName = "Martina Černá" });
            applications.Add(new Applicant { Id = 401, Score = 71, RealName = "Tomáš Pokorný" });
            applications.Add(new Applicant { Id = 351, Score = 38, RealName = "Karel Antoš" });
            applications.Add(new Applicant { Id = 14, Score = 81, RealName = "Jana Poláková" });
            applications.Add(new Applicant { Id = 221, Score = 33, RealName = "Adam Tichý" });
            applications.Add(new Applicant { Id = 20, Score = 85, RealName = "Marcel Zrzavý" });
            applications.Add(new Applicant { Id = 10, Score = 12, RealName = "Daniel Drsný" });
            foreach (var app in applications)
            {
                Console.WriteLine(app);
            }
            Console.WriteLine("Otočení Listu: ");
            foreach (var a in applications.Swap(applications))
            {
                Console.WriteLine(a.Id);
            }
            Console.WriteLine("------");
            

            SimpleBinaryTree<Applicant> applicationsTree = new SimpleBinaryTree<Applicant>();
            applicationsTree.Add(new Applicant { Id = 520, Score = 50, RealName = "Jiří Vokurka" });
            applicationsTree.Add(new Applicant { Id = 415, Score = 61, RealName = "Martina Černá" });
            applicationsTree.Add(new Applicant { Id = 401, Score = 71, RealName = "Tomáš Pokorný" });
            applicationsTree.Add(new Applicant { Id = 351, Score = 38, RealName = "Karel Antoš" });
            applicationsTree.Add(new Applicant { Id = 14, Score = 81, RealName = "Jana Poláková" });
            applicationsTree.Add(new Applicant { Id = 221, Score = 33, RealName = "Adam Tichý" });
            applicationsTree.Add(new Applicant { Id = 20, Score = 85, RealName = "Marcel Zrzavý" });
            applicationsTree.Add(new Applicant { Id = 10, Score = 12, RealName = "Daniel Drsný" });
            Console.WriteLine(applicationsTree);
            Console.WriteLine("MAX: " + applicationsTree.Max());
            Console.WriteLine(applicationsTree.Overfifty());
            // Vytvořte:
            // 1. Metodu, která otočí LinkedList do opačného pořadí (10,20,221,14,351,401,415,520)
            // 2. Metodu, která vrátí nebo vytvoří LinkedList všech uchazečů, kteří splní podmínku (například Score > 50) (ideálně pomocí delegátu a lambda operací)
            // 3. Metodu, která vrátí ze stromu nejvyšší dosažené skóre uchazeče
            // 4. Metodu, která vrátí (jakkoliv) všechny uchazeče, kteří splní podmínku (například Score > 50) (ideálně pomocí delegátu a lambda operací)
            // 5. Metodu Insert, která na základě parametru vlepí novou položku do seznamu na správné místo (parametrem se volí řazení seznamu).
        }
    }
}
