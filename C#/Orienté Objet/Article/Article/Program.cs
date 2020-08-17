using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Donner le taux de TVA pour tous les articles : ");

            Article.TauxTVA = int.Parse(Console.ReadLine());

            Console.WriteLine($"Le taux pour tous les articles est de : {Article.TauxTVA}%");

            Article article1 = new Article();
            Article article2 = new Article("1","Chaise en bois");
            Article article3 = new Article("2", "Meuble de salon", 10.0);
            Article article4 = new Article(article2);

            article1.AfficherArticle();
            Console.WriteLine();

            article2.AfficherArticle();
            Console.WriteLine();

            article3.AfficherArticle();
            Console.WriteLine();

            article4.AfficherArticle();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
