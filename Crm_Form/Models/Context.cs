using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_Form.Models
{

    public class Context
        
    {
        public Context()
        {
            for (int i = 0; i < 5; i++)
            {
                Kisiler.Add(new Kisi()
                {
                    Ad = Faker.NameFaker.Name(),
                    SoyAd = Faker.NameFaker.LastName(),
                    DogumTarihi = Faker.DateTimeFaker.BirthDay(),
                    Falan = Faker.NumberFaker.Number(1000, 9999)
                });

            }
        }      
        public List<Kisi> Kisiler { get; set; } = new List<Kisi>();
    }
}
