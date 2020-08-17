using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Article
    {

        private string _Référence;
        private string _Désignation;
        private double _PrixHTVA;
        private static int _TauxTVA;

        public Article()
        {

        }

        public Article(string référence, string désignation, double prixHTVA)
        {
            _Référence = référence;
            _Désignation = désignation;
            _PrixHTVA = prixHTVA;
        }

        public Article(string référence, string désignation)
        {
            _Référence = référence;
            _Désignation = désignation;
        }

        public Article(Article article)
        {
            _Référence = article.Référence;
            _Désignation = article.Désignation;
            _PrixHTVA = article.PrixHTVA;
        }

        public string Référence
        {
            get
            {
                return _Référence;
            }
            set
            {
                if (value != _Référence)
                    _Référence = value;
            }
        }

        public string Désignation
        {
            get
            {
                return _Désignation;
            }
            set
            {
                if (value != _Désignation)
                    _Désignation = value;
            }
        }

        public double PrixHTVA
        {
            get
            {
                return _PrixHTVA;
            }
            set
            {
                if (value != _PrixHTVA)
                    _PrixHTVA = value;
            }
        }
        public static int TauxTVA
        {
            get
            {
                return _TauxTVA;
            }
            set
            {
                if (value != _TauxTVA)
                    _TauxTVA = value;
            }
        }

        public double CalculerPrixTTC()
        {
            return PrixHTVA + (PrixHTVA * (TauxTVA / 100.0));
        }

        public void AfficherArticle()
        {
            Console.WriteLine($"Référence : {Référence}");
            Console.WriteLine($"Désignation : {Désignation}");
            Console.WriteLine($"PrixHTVA : {PrixHTVA}€");
            Console.WriteLine($"PrixTTC : {CalculerPrixTTC()}€");
        }

    }
}
