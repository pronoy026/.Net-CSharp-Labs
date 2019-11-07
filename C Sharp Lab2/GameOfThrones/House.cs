using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    class House
    {
        public string HouseId { get; set; }
        public string HouseName { get; set; }
        public string HouseLocation { get; set; }

        public House(string houseId, string name, string location)
        {
            HouseId = houseId;
            HouseName = name;
            HouseLocation = location;
        }

        public override string ToString()
        {
            return string.Format($"HouseId : {HouseId}, Name : {HouseName}, Location : {HouseLocation}");
        }

        public static List<House> GetGreatHousesList()
        {
            return new List<House>()
            {
                new House("SIA", "House Strak", "Winterfel-The North"),
                new House("LAN", "House Lannister", "Casterly Rock-Westernlands"),
                new House("GRE", "House Greyjoy", "Salt Castle-Iron Islands"),
                new House("TAR", "House Targaryan", "Dragonstone-Crownlands"),
                new House("TRL", "Tarly", "Hornhill")
            };
        }
    }
}
