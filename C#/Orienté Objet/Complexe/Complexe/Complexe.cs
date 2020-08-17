using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexe
{
    class Complexe
    {

        private int _PartieRéelle;
        private int _PartieImaginaire;

        public Complexe()
        {
            _PartieRéelle = 0;
            _PartieImaginaire = 0;
        }

        public Complexe(int partieRéelle, int partieImaginaire)
        {
            _PartieRéelle = partieRéelle;
            _PartieImaginaire = partieImaginaire;
        }

        public int PartieRéelle
        {
            get
            {
                return _PartieRéelle;
            }
        }

        public int PartieImaginaire
        {
            get
            {
                return _PartieImaginaire;
            }
        }

        public Complexe Plus(Complexe complexe)
        {
            return new Complexe(this._PartieRéelle + complexe.PartieRéelle, this._PartieImaginaire + complexe.PartieImaginaire);

        }
        public Complexe Moins(Complexe complexe)
        {
            return new Complexe(this._PartieRéelle - complexe.PartieRéelle, this._PartieImaginaire - complexe.PartieImaginaire);

        }

        public void Afficher()
        {
            Console.Write($"Nombre complexe : {_PartieRéelle}");

            if (_PartieImaginaire >= 0)
                Console.WriteLine($"+{_PartieImaginaire}i");
            else
                Console.WriteLine($"{_PartieImaginaire}i");

        }
    }
}
