using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Species.Species
{
    public class Species
    {

        private Dictionary<Guid, Specie> _Specie = new Dictionary<Guid, Specie>();

        private Guid SpecieID;

        private void PopulateDictionary()
        {
            _Specie.Add(Guid.Parse("26ff7ad2-5410-415a-9757-b05986b5d9ec"), Specie.Android);
            _Specie.Add(Guid.Parse("eea655f5-2515-4965-a7fa-257f4741714c"), Specie.Electric);
            _Specie.Add(Guid.Parse("b0a29f41-64f5-4f0c-9072-71b93887fd63"), Specie.Magma);
            _Specie.Add(Guid.Parse("ff548e97-852d-4c2a-9d7f-111cd590c4a2"), Specie.Nature);
            _Specie.Add(Guid.Parse("2acf43ac-f391-4745-b5b9-d3af71d49abc"), Specie.Ocean);
            _Specie.Add(Guid.Parse("f3deb6be-679b-4ce3-b91b-93f2a705a878"), Specie.Shape_Shifter);
            _Specie.Add(Guid.Parse("16244d4d-04cc-4eb3-a382-d4b297729fbe"), Specie.Steel);
            _Specie.Add(Guid.Parse("1aba36e1-3a3a-4129-b49c-d6609ae0231b"), Specie.Virus);
            _Specie.Add(Guid.Parse("560d3bd6-4052-4313-88b8-04ec87002b21"), Specie.Wild);
        }


        public Species()
        {
            PopulateDictionary();
        }

        public List<string> PopulateSpecie()
        {
            List<string> specie = new List<string>();
            foreach (KeyValuePair<Guid, Specie> pair in _Specie)
            {
                specie.Add($"INSERT INTO SPECIES Values(\"{pair.Key.ToString()}\", '{pair.Value.ToString()}');");
            }
            return specie;
        }

    }

    public enum Specie
    {
        Android,
        Steel,
        Magma,
        Ocean,
        Virus,
        Nature,
        Wild,
        Electric,
        Shape_Shifter
    }

}
