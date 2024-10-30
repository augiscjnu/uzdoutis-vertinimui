using Knygos.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Knygos.Core.Repositories
{
    public class KnyguRepository
    {
        private string _fileLocation;
        private List<Knyga> knygos;

        public KnyguRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
            knygos = NuskaitoKnygas();
        }

        private List<Knyga> NuskaitoKnygas()
        {
            List<Knyga> knygos = new List<Knyga>();

            foreach (var eilute in File.ReadLines(_fileLocation))
            {
                var duomenys = eilute.Split(',');
                knygos.Add(new Knyga
                {
                    KnygosID = int.Parse(duomenys[0]),
                    Pavadinimas = duomenys[1],
                    Autorius = duomenys[2],
                    IsleidimoMetai = int.Parse(duomenys[3]),
                    Zanras = duomenys[4]
                });
            }

            return knygos;
        }

        public List<Knyga> RastiKnygasPagalAutoriu(string autorius)
        {
            return knygos.Where(k => k.Autorius.Contains(autorius, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Knyga> RastiKnygasPagalMetus(int metai)
        {
            return knygos.Where(k => k.IsleidimoMetai >= metai).ToList();
        }

        public List<Knyga> RastiKlasikosKnygas()
        {
            return knygos.Where(k => k.Zanras.Equals("Classic", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
