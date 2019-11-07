using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HouseId { get; set; }
        public string Gender { get; set; }

        public static List<Hero> GetHeroesList()
        {
            List<Hero> westerosHeroes = new List<Hero>()
            {
                new Hero { Id = 101, Name = "Arya Stark", HouseId = "STA", Gender = "F" },
                new Hero { Id = 102, Name = "Jon Snow", HouseId = "STA", Gender = "M" },
                new Hero { Id = 103, Name = "Sansa Stark", HouseId = "STA", Gender = "F" },
                new Hero { Id = 104, Name = "Bran Stark", HouseId = "STA", Gender = "M" },
                new Hero { Id = 201, Name = "Cercei Lannister", HouseId = "LAN", Gender = "F" },
                new Hero { Id = 202, Name = "Jaime Lannister", HouseId = "LAN", Gender = "M" },
                new Hero { Id = 301, Name = "Daenerys Targaryen", HouseId = "TAR", Gender = "F"},
                new Hero { Id = 302, Name = "Missandei", HouseId = "TAR", Gender = "F"},
                new Hero { Id = 401, Name = "Yara Greyjoy", HouseId = "GRE", Gender = "F"},
                new Hero { Id = 402, Name = "Theon Greyjoy", HouseId = "GRE", Gender = "M"},
                new Hero { Id = 403, Name = "Euron Greyjoy", HouseId = "GRE", Gender = "M"},
                new Hero { Id = 501, Name = "Samwell Tarly", HouseId = "TRL", Gender = "M"}
            };
            return westerosHeroes;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, HouseId : {HouseId}, Gender : {Gender}";
        }
    }
}
