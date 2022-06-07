using ŠKL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠKL.ViewModel
{
    class LigaViewModel
    {
        public EkipaViewModel EkipaJimmy { get; set; }
        public EkipaViewModel EkipaJanez { get; set; }
        public LigaViewModel()
        {
            Ekipa j = new Ekipa("Bomberji", DobiBomberje());
            EkipaJanez = new EkipaViewModel(j);
            Ekipa m = new Ekipa("Fantastic", DobiFantastice());
            EkipaJimmy = new EkipaViewModel(m);
        }

        private IEnumerable<Igralec> DobiFantastice()
        {
            List<Igralec> i = new List<Igralec>()
            {
            new Igralec("Jimmy",true,42),
            new Igralec("Henry",true,11),
            new Igralec("Bob",true,4),
            new Igralec("Lucinda",true,18),
            new Igralec("Kim",true,16),
            new Igralec("Berta",false,23),
            new Igralec("Ed",false,21)
            };
            return i;
        }

        private IEnumerable<Igralec> DobiBomberje()
        {
            List<Igralec> i = new List<Igralec>()
            {
            new Igralec("Brian",true,31),
            new Igralec("LLoyd",true,23),
            new Igralec("Katarina",true,6),
            new Igralec("Mike",true,1),
            new Igralec("Joe",true,11),
            new Igralec("Alenka",false,8),
            new Igralec("Tanja",false,10)
            };
            return i;
        }
    }
}
