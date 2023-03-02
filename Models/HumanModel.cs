using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Models
{
    public class HumanModel
    {
        // Id, Nombre, Sexo, Edad, Altura y Peso
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }

        public class HumanMock
        {
            public static HumanModel[] GetHumans()
            {
                var humans = new HumanModel[]
                {
                    new HumanModel { id = 1, name = "Juan", age = "22", gender = "Masculino", height = 80 , weight = 1.78M},
                    new HumanModel { id = 2, name = "Erick", age = "26", gender = "Masculino", height = 70 , weight = 1.70M},
                    new HumanModel { id = 3, name = "Pedro", age = "28", gender = "Masculino", height = 65 , weight = 1.65M},
                    new HumanModel { id = 4, name = "Karen", age = "26", gender = "Femenino", height = 50 , weight = 1.55M},
                    new HumanModel { id = 5, name = "Luis", age = "29", gender = "Masculino", height = 45 , weight = 1.50M},
                };

                return humans;
            }
        }
    }
}
